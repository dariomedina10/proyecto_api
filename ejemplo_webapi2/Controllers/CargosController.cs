using Datos;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ejemplo_webapi2.Controllers
{
    public class CargosController : ApiController
    {
        private Meru_LinkEntities Context = new Meru_LinkEntities();

        [HttpGet]
        public IEnumerable<Cargos> Get()
        {
            using (Meru_LinkEntities db = new Meru_LinkEntities()) 
            {
                return db.Cargos.ToList();    

            }
        }

        [HttpGet]

        public Cargos Get(int id) {

            using (Meru_LinkEntities db = new Meru_LinkEntities())
            {
                return db.Cargos.FirstOrDefault(x => x.Departamento_id ==id);

            }


        }

        [HttpPost]

        public IHttpActionResult AgregarCargo([FromBody] Cargos cargo)
        {
            if (ModelState.IsValid)
            {
                Context.Cargos.Add(cargo);
                Context.SaveChanges();
                return Ok(cargo);

            }else {

                return BadRequest();
            
            }

        }

        [HttpPut]

        public IHttpActionResult ActualizarCargo(int id, [FromBody] Cargos cargo)
        {
            if (ModelState.IsValid)
            {
                var cargoexiste = Context.Cargos.Count(e => e.Departamento_id == id) > 0;
                if (cargoexiste)
                {
                    Context.Entry(cargo).State = EntityState.Modified;
                    Context.SaveChanges();
                    return Ok(cargo);
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return BadRequest();
            }

            
        }

        [HttpDelete]
        public IHttpActionResult EliminarCargo(int id) { 
            var cargo =Context.Cargos.Find(id);

            if (cargo !=null)

            {
                Context.Cargos.Remove(cargo);
                Context.SaveChanges();
                return Ok(cargo);
            } else
                {
                return NotFound();
            }


        }
    }

}
