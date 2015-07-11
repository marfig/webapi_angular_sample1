using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiEjemplo1.Models;

namespace WebApiEjemplo1.Controllers
{
    public class ValuesController : ApiController
    {
        static List<Pais> paises = new List<Pais>()
        {
            new Pais { Id = 1, Nombre = "Paraguay" },
            new Pais { Id = 2, Nombre = "Brasil" },
            new Pais { Id = 3, Nombre = "Argentina" },
            new Pais { Id = 4, Nombre = "Chile" },
            new Pais { Id = 5, Nombre = "Nigeria" },
            new Pais { Id = 6, Nombre = "Colombia" },
            new Pais { Id = 7, Nombre = "Uruguay" },
            new Pais { Id = 8, Nombre = "Ecuador" }
        };

        // GET api/values
        public IEnumerable<Pais> Get()
        {
            return paises;
        }

        // GET api/values
        public Pais Get(int id)
        {
            return paises.FirstOrDefault(c => c.Id == id);
        }

        // POST api/values
        public void Post([FromBody]Pais pais)
        {
            paises.Add(pais);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Pais pais)
        {
            var item = paises.FirstOrDefault(c => c.Id == id);

            if (item == null) return;
            item.Nombre = pais.Nombre;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            paises.Remove(paises.FirstOrDefault(c => c.Id == id));
        }
    }
}