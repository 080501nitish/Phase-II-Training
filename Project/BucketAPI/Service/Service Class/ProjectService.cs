using Bucket.Context;
using Bucket.Global_Exceptions;
using Bucket.Models;
using Bucket.Models.tempModels;
using Bucket.Service.Interface;
using MathNet.Numerics.Distributions;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using SixLabors.Fonts.Tables.AdvancedTypographic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Project = Bucket.Models.Project;
using Tag = Bucket.Models.Tag;

namespace Bucket.Service.Service_Class
{

    public class ProjectService : IProjects
    {
        public BucketContext _bucketContext;
        public ProjectService(BucketContext bucketContext)
        {
            _bucketContext = bucketContext;
        }
        public async Task<PostProjectResult> AddProject(ProjectInput input)
        {
            var newProject = new Project
            {
                ProjectTitle = input.ProjectTitle,
                ProjectDescription = input.ProjectDescription,
                ProjectCreatedAt = DateTime.Now,
                UserID = input.UserID
            };

            if (input.Media.Count > 4)
            {
                return new PostProjectResult
                {
                    Success = false,
                    Message = "Maximum of 4 media allowed"
                };
            }

            if (input.Tags.Count > 10)
            {
                return new PostProjectResult
                {
                    Success = false,
                    Message = "Maximum of 10 tags allowed"
                };
            }

           

            foreach (var mediaInput in input.Media)
            {
                if (newProject.Media.Count < 4) 
                {
                    newProject.Media.Add(new Media
                    {


                        MediaURL = mediaInput.MediaURL,
                        Caption = mediaInput.Caption
                    });
                }
            }

            foreach (var tagName in input.Tags)
            {
                var existingTag = await _bucketContext.Tags
            .FirstOrDefaultAsync(t => EF.Functions.Collate(t.TagName, "SQL_Latin1_General_CP1_CI_AS") == tagName);
                if (newProject.ProjectTags.Count < 10)
                {
                    if (existingTag != null)
                    {
                        // Tag exists, map its ID
                        newProject.ProjectTags.Add(new ProjectTag
                        {
                            Tags = existingTag
                        });
                    }
                    else
                    {
                        // Tag does not exist, create a new one
                        var newTag = new Tag { TagName = tagName };
                        _bucketContext.Tags.Add(newTag);

                        newProject.ProjectTags.Add(new ProjectTag
                        {
                            Tags = newTag
                        });
                    }
                }
            }

               /* foreach (var tagName in input.Tags)
            {
                if (newProject.ProjectTags.Count < 10) 
                {
                    newProject.ProjectTags.Add(new ProjectTag
                    {
                        Tags = new Tag { TagName = tagName }
                    });
                }
            }*/

            _bucketContext.Projects.Add(newProject);
            await _bucketContext.SaveChangesAsync();

            return new PostProjectResult
            {
                Success = true,
                Message = "Project posted successfully",
                NewProjectID = newProject.ProjectID
            };
        }

        /* public async Task<List<Project>> DeleteProject(int id)
         {
             Project rproject = await _bucketContext.Projects.FindAsync(id);
             if (rproject == null)
             {
                 throw new Exception(UserDetailsExceptions.UsernotFoundException["NotFound"]);
             }
             else
             {
                 _bucketContext.Remove(rproject);
                 await _bucketContext.SaveChangesAsync();
                 return await _bucketContext.Projects.ToListAsync();
             }
         }*/

        public async Task<ProjectDetails> GetProjectByID(int id)
        {
            var ProjectDetailsList = await (from project in _bucketContext.Projects
                                                /*join media in _bucketContext.Medias on project.ProjectID equals media.ProjectID into mediagroup*/
                                            join projectTag in _bucketContext.ProjectTags on project.ProjectID equals projectTag.ProjectID into projectTagGroup
                                            where project.ProjectID == id
                                            /*join comment in _bucketContext.Comments on project.ProjectID equals comment.ProjectID into commentGroup*/
                                            select new ProjectDetails
                                            {
                                                ProjectTitle = project.ProjectTitle,
                                                ProjectDescription = project.ProjectDescription,
                                                ProjectCreatedAt = (DateTime)project.ProjectCreatedAt,
                                                Username = project.Users.UserName,
                                                Media = (
                                                    from c in _bucketContext.Medias
                                                    where c.ProjectID == project.ProjectID
                                                    select new ProjectionMedia
                                                    {
                                                        MediaURL = c.MediaURL,
                                                        Caption = c.Caption
                                                    }).ToList(),
                                                LikeCount = _bucketContext.Likes.Count(like => like.ProjectID == project.ProjectID),
                                                /* MediaUrls = mediagroup.Select(mg => mg.MediaURL).Where(Mediaurl => Mediaurl != null).ToList(),*/

                                                Tags = projectTagGroup.Select(pt => pt.Tags.TagName)
                                                   .Where(tagName => tagName != null)
                                                   .ToList(),

                                                Comments = (
                                                    from c in _bucketContext.Comments
                                                    join u in _bucketContext.Users on c.UserID equals u.UserID
                                                    where c.ProjectID == project.ProjectID
                                                    select new ProjectComment
                                                    {
                                                        CommentContent = c.CommentContent,
                                                        CommentedUsername = u.UserName,
                                                        CommentedTime = c.CommentedAt
                                                    }).ToList()
                                            }).FirstOrDefaultAsync();
            if (ProjectDetailsList == null)
            {
                throw new Exception(UserDetailsExceptions.UsernotFoundException["NotFound"]);
            }
            else
            {
                return ProjectDetailsList;
            }
        }

        public async Task<UpdateProjectResult> UpdateProject(int id, UpdateProjectInput input)
        {
            var project = await _bucketContext.Projects
                .Include(p => p.Media)
                .Include(p => p.ProjectTags)
                .FirstOrDefaultAsync(p => p.ProjectID == id);

            if (project == null)
            {
                return new UpdateProjectResult
                {
                    Success = false,
                    Message = "Project not found"
                };
            }
            if (input.Media.Count > 4)
            {
                return new UpdateProjectResult
                {
                    Success = false,
                    Message = "Maximum of 4 media allowed"
                };
            }

            if (input.Tags.Count > 10)
            {
                return new UpdateProjectResult
                {
                    Success = false,
                    Message = "Maximum of 10 tags allowed"
                };
            }
            project.ProjectTitle = input.ProjectTitle;
            project.ProjectDescription = input.ProjectDescription;

            project.Media.Clear();
            project.ProjectTags.Clear();

            foreach (var mediaInput in input.Media)
            {
                if (project.Media.Count < 4)
                {
                    project.Media.Add(new Media
                    {
                        MediaURL = mediaInput.MediaURL,
                        Caption = mediaInput.Caption
                    });
                }
            }

            foreach (var tagName in input.Tags)
            {
                var existingTag = await _bucketContext.Tags
            .FirstOrDefaultAsync(t => EF.Functions.Collate(t.TagName, "SQL_Latin1_General_CP1_CI_AS") == tagName);
                if (project.ProjectTags.Count < 10)
                {
                    if (existingTag != null)
                    {
                        // Tag exists, map its ID
                        project.ProjectTags.Add(new ProjectTag
                        {
                            Tags = existingTag
                        });
                    }
                    else
                    {
                        // Tag does not exist, create a new one
                        var newTag = new Tag { TagName = tagName };
                        _bucketContext.Tags.Add(newTag);

                        project.ProjectTags.Add(new ProjectTag
                        {
                            Tags = newTag
                        });
                    }
                }
            }
            /*foreach (var tagName in input.Tags)
            {
                if (project.ProjectTags.Count < 10)
                {
                    project.ProjectTags.Add(new ProjectTag
                    {
                        Tags = new Tag { TagName = tagName }
                    });
                }
            }*/


            await _bucketContext.SaveChangesAsync();

            return new UpdateProjectResult
            {
                Success = true,
                Message = "Project updated successfully"
            };

    }

        public async Task<List<HomePageProjection>> GetAllProjects()
        {
            var HomePageProjectionList = await (from project in _bucketContext.Projects
                                            join user in _bucketContext.Users on  project.UserID equals user.UserID
                                                join media in _bucketContext.Medias on project.ProjectID equals media.ProjectID into mediagroup
                                            select new HomePageProjection
                                            {
                                                ProjectID = project.ProjectID,
                                                ProjectTitle = project.ProjectTitle,
                                                UserName = project.Users.UserName,
                                                LikeCount = _bucketContext.Likes.Count(like => like.ProjectID == project.ProjectID),
                                                MediaURL = mediagroup.Select(mg => mg.MediaURL).Where(Mediaurl => Mediaurl != null).First()


                                            }).ToListAsync();
            if (HomePageProjectionList == null)
            {
                throw new Exception(UserDetailsExceptions.UsernotFoundException["NotFound"]);
            }
            else
            {
                return HomePageProjectionList;
            }

        }




    }
}
