using apiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace apiWeb.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class GeneradorController : ApiController
    {
        [ResponseType(typeof(Clave))]
        public async Task<IHttpActionResult> getClave(string level, int pLongitud)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            GeneradorClave gC = new GeneradorClave(level,pLongitud);
            string clave=gC.GenerarClave(level,pLongitud);
            Clave obj=new Clave(clave, level);
            return Ok(obj);
        }
    }
}
