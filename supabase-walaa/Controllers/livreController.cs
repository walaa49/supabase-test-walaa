using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using supabase_walaa.Models;
using supabase_walaa.classes;

namespace supabase_walaa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class livreController : ControllerBase
    {

        Supabase.Client context = clslivre.getInstance().Result;

        // GET: api/<Controller>
        [HttpGet]
        async public Task<ActionResult> Get()
        {           
            var res = context.From<Livre>().Select("*").Get().Result.Content.ToString();          
            return Ok(res);
        }   

        // GET api/<livreController>/5
        [HttpGet("{id}")]
        async public Task<ActionResult> Get(int id)
        {
            //return "value" + id.ToString();
            var res = context.From<Livre>().Select("*").Filter("id", Postgrest.Constants.Operator.Equals, id).Limit(1).Get().Result;

            return Ok(res.Content);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult Post(string titre, string auteur)
        {
            if(!String.IsNullOrEmpty(titre) && !String.IsNullOrEmpty(auteur))
            {
                

                var l = new Livre();
                l.titre = titre;
                l.auteur = auteur;

                var res = context.From<Livre>().Insert(l).Result.Content;
                return Ok(res);

            }
            return NotFound();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
