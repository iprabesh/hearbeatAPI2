using heartBeatServerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace heartBeatServerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramCheckController : ControllerBase
    {
        //static programCheck pCheck = new programCheck(1, "test.exe", 0, 2);    
        // GET api/values
        static readonly IProgramCheckRepository repository = new ProgramCheckRepository();
        [HttpGet]
        public IEnumerable<programCheck> Get()
        {
           return repository.GetAll();
        }
       
       [HttpGet("{id}")]
       public programCheck GetProduct(int id)
        {
            programCheck item = repository.Get(id);
            
            return item;
        }
      // POST api/values
        [HttpPost]
       /*  public int Post([FromBody] programCheck pCheck1)
        {
            pCheck.Id = pCheck1.Id; 
            pCheck.programCount = pCheck1.programCount; 
            pCheck.programName = pCheck.programName; 
            pCheck.programLimit = pCheck.programLimit; 
            
            return pCheck1.programCount; 
        } */

        // PUT api/values/5
        [HttpPut("{id}")]
       public void PutProduct(int id, programCheck product)
        {
            product.Id = id;
            if (!repository.Update(product))
            {
                Console.WriteLine("Failed");
                //throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}