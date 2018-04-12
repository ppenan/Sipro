using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SiproNET.Models;
using SiproNET.DAO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SiproNET.Controllers
{
    [Route("api/[controller]")]
    public class ActividadPropiedadController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            actividad_propiedad temp = ActividadPropiedadDAO.GetActividadPropiedad();
            return new string[] { temp.id.ToString(), temp.nombre, temp.fecha_creacion.ToString(), temp.fecha_actualizacion.ToString() };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
            actividad_propiedad temp = ActividadPropiedadDAO.GetActividadPropiedad();
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
