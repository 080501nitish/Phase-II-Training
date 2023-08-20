using Bucket.Models;
using Bucket.Models.tempModels;
using Bucket.Service.Service_Class;

namespace Bucket.Service.Interface
{
    public interface IProjects
    {
        //projects API Endpoint
        Task<ProjectDetails> GetProjectByID(int id);
        Task<PostProjectResult> AddProject(ProjectInput input);

        Task<List<HomePageProjection>> GetAllProjects();

        Task<UpdateProjectResult> UpdateProject(int id, UpdateProjectInput input);
 /*       Task<Project> UpdateProject(int id,int userid, Project project);
        Task<List<Project>> DeleteProject(int id);*/
    }
}
