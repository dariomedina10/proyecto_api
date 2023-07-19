using Datos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
//using System.Net.Http;
using System.Web.Http;

namespace ejemplo_webapi2
{
    public class ValuesController1 : ApiController
    {
        private Meru_LinkEntities Context = new Meru_LinkEntities();
        // GET api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            using (Meru_LinkEntities db = new Meru_LinkEntities())
            {
                return (IEnumerable<string>)db.Cargos.ToList();
            }

            // return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5

        [HttpGet]
        public Cargos Get(int id)
        {

            using (Meru_LinkEntities db = new Meru_LinkEntities())
            {
                //VariableString = Convert.ToString(variable entera);
                //VariableString = variableEntera.ToString();
                // id= Convert.ToString(id);


                return db.Cargos.FirstOrDefault(x => x.codigo == id);

                //return "value";
            }



        }

        // POST api/<controller>
        [HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        public IHttpActionResult AgregarCargos([FromBody] Cargos cargos)
        {

            if (ModelState.IsValid)
            {
                Context.Cargos.Add(cargos);
                Context.SaveChanges();
                return Ok(cargos);
            }
            else
            {

                return BadRequest();
            }

        }


        // PUT api/<controller>/5

        [HttpPut]
        public IHttpActionResult ActualizarCargo(int id, [FromBody] Cargos cargos)
        {

            if (ModelState.IsValid)
            {
                var cargoexiste = Context.Cargos.Count(e => e.Departamento_id == id) > 0;
                if (cargoexiste)
                {
                    Context.Entry(cargos).State = EntityState.Modified;
                    Context.SaveChanges();
                    return Ok(cargos);

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



      //  DELETE api/<controller>/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var cargos = Context.Cargos.Find(id);

              if (cargos != null)
            {
                Context.Cargos.Remove(cargos);
                Context.SaveChanges();
                return Ok(cargos);
            }else {
                return NotFound();

            }
        }

    }
}