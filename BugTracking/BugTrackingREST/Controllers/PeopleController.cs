using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

using System.Web.Http;
using BOL;
using BLL;
using System.Web.Http.Cors;
using DAL;


namespace BugTrackingREST.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class PeopleController : ApiController
    {

        
        // GET: api/People
        public IEnumerable<People> Get()
        {
            return BusinessManager.GetAllPeople();
        }

         //GET: api/People/5
        public People Get(int id)
        {
            return BusinessManager.GetPeople(id);
        }

        // POST: api/People
        public void Post([FromBody] People newPerson)
        {
            BusinessManager.Insert(newPerson);

        }





        [HttpPost]
        [Route("api/People/Login")]
        public People Login([FromBody] People Object)
        {
            string Email = Object.personEmail;
            string pass = Object.password;
            int status=BusinessManager.Login(Email, pass);
            
            return Object;
        }




        

    


// PUT: api/People/5
public HttpResponseMessage Put(int id, [FromBody] People existingPerson)
        {
            People obj = new People();
            obj = BusinessManager.Update(id,existingPerson);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, obj);
            return response;
        }

        // DELETE: api/People/5
        [HttpDelete]
        public void Delete(int id)
        {
            BusinessManager.Delete(id);
        }
    }
}
