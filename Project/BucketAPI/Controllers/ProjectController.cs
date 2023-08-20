using Bucket.Models;
using Bucket.Models.tempModels;
using Bucket.Service.Interface;
using Bucket.Service.Service_Class;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;
using Microsoft.CodeAnalysis;
using Microsoft.DotNet.Scaffolding.Shared.ProjectModel;
using Project = Bucket.Models.Project;

namespace Bucket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        public IProjects _bucket;
        public ProjectController(IProjects bucket)
        {
            _bucket = bucket;
        }
        [HttpPost]
        public async Task<ActionResult<PostProjectResult>> AddProject(ProjectInput input)
        {
            
            var projects = await _bucket.AddProject(input);
            return Ok(projects);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectDetails>> GetProjectByID(int id)
        {
            var projects = await _bucket.GetProjectByID(id);
            if(projects == null)
            {
                return NotFound();
            }
            return Ok(projects);
            
        }
        [HttpGet]
        public async Task<ActionResult<List<HomePageProjection>>> GetAllProjects()
        {
            var projects = await _bucket.GetAllProjects();
            if (projects == null)
            {
                return NotFound();
            }
            return Ok(projects);

        }

        [HttpPut]
         public async Task<ActionResult<UpdateProjectResult>> UpdateProject(int id, UpdateProjectInput input)
         {
             try
             {
                 var projects = await _bucket.UpdateProject(id,input);
                 return Ok(projects);
             }
             catch (Exception ex)
             {
                 return NotFound(ex.Message);
             }
         }

        /* [HttpDelete]
         public async Task<ActionResult<List<User>>> DeleteProject(int id)
         {
             try
             {
                 var users = await _bucket.DeleteProject(id);
                 return Ok(users);
             }
             catch (Exception ex)
             {
                 return NotFound(ex.Message);
             }
         }*/
    }
}
