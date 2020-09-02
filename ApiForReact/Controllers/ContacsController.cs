using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiForReact.Modelos;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ApiForReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        // GET api/values

        [HttpGet]
        [EnableCors("AllowOrigin")]
        public async Task<ActionResult<List<Contact>>> Get()
        {
            var list =  await GetListAsync();
            return  list;
        }

        public async Task<List<Contact>> GetListAsync()
        {
            List<Contact> contacts =  new List<Contact>()
            {
                new Contact()
                {
                    ContactId = 1,
                    Name = "Piter Gram",
                    Email = "ariel.reyes@gmail.com",
                    Companies = new List<Company>()
                    {
                        new Company()
                        {
                            Name = "Facebook",
                            CatchPhrase = "Complex programmings"
                        }
                    }
                },
                 new Contact()
                {
                    Name = "Gomex Peries",
                    Email = "ariel.reyes@gmail.com",
                    Companies = new List<Company>()
                    {
                        new Company()
                        {
                            Name = "Google",
                            CatchPhrase = "Complex programmings"
                        }
                    }
                },
                      new Contact()
                {
                    Name = "Axios Peries",
                    Email = "ariel.reyes@gmail.com",
                    Companies = new List<Company>()
                    {
                        new Company()
                        {
                            Name = "Google",
                            CatchPhrase = "Complex programmings"
                        }
                    }
                }

            };
            return await Task.Run(() => contacts);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
