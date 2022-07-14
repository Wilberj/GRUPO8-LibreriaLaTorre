using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CAPA_NEGOCIO;

namespace Libreria.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        [HttpPost]
        public object SaveCompra(object ObjIns)
        {
            TabCompra Ins = JsonConvert.DeserializeObject<TabCompra>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public object GetCompra()
        {
            List<Object> Response = new List<object>();

            TabCompra CC = new TabCompra();
            Response.Add(CC.GetList(CC));
            TabProveedor CP = new TabProveedor();
            Response.Add(CP.Get(CP));
            return Response;
        }
    }
}
