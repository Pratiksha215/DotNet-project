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
    public class IssuesController : ApiController
    {
        // GET: Issues
        public IEnumerable<Issues> Get()
        {
            return IssueBusinessManager.GetAllIssues();
        }
       
        //GET: api/Issues/5
        public Issues Get(int id)
        {
            return IssueBusinessManager.GetIssues(id);
        }

        // POST: api/Projects
        public void Post([FromBody] Issues newIssue)
        {
            IssueBusinessManager.Insert(newIssue);
        }

        // PUT: api/Projects/5
        public HttpResponseMessage Put(int id, [FromBody] Issues existingIssue)
        {
            Issues obj = new Issues();
            obj = IssueBusinessManager.Update(id, existingIssue);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, obj);
            return response;
        }

        // DELETE: api/Projects/5
        [HttpDelete]
        public void Delete(int id)
        {
            IssueBusinessManager.Delete(id);
        }
    }
}
