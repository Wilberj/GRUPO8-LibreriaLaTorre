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
    public class DetailComp : ControllerBase
    {
        [HttpPost]
        public object SaveDetalle(object ObjIns)
        {
            TabDetalleCompra Ins = JsonConvert.DeserializeObject<TabDetalleCompra>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public object GetDetalle()
        {
            List<Object> Response = new List<object>();

            TabDetalleCompra CC = new TabDetalleCompra();
            Response.Add(CC.GetList(CC));
            TabCompra CP = new TabCompra();
            Response.Add(CP.GetList(CP));
            return Response;
        }
    }
}
