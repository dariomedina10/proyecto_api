using Datos;
using System;
using System.Collections.Generic;
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

    }

}
