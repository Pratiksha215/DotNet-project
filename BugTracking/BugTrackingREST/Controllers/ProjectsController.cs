using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BOL;
using BLL;
using System.Web.Http.Cors;

namespace BugTrackingREST.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ProjectsController : ApiController
    {
        // GET: Projects
        public IEnumerable<Projects> Get()
        {
            return ProjectBusinessManager.GetAllProjects();
        }

        //GET: api/Projects/5
        public Projects Get(int id)
        {
            return ProjectBusinessManager.GetProjects(id);
        }

        // POST: api/Projects
        public void Post([FromBody] Projects newProject)
        {
            ProjectBusinessManager.Insert(newProject);
        }

        // PUT: api/Projects/5
        public HttpResponseMessage Put(int id, [FromBody] Projects existingProject)
        {
            Projects obj = new Projects();
            obj = ProjectBusinessManager.Update(id, existingProject);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, obj);
            return response;
        }

        // DELETE: api/Projects/5
        [HttpDelete]
        public void Delete(int id)
        {
            ProjectBusinessManager.Delete(id);
        }
    }
}
    

