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
    public class StockController : ControllerBase
    {
        [HttpPost]
        public object SaveStock(Object ObjIns)
        {
            TabStock Ins = JsonConvert.DeserializeObject<TabStock>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public object Getstock()
        {
           List<object> Response = new List<object>();

           TabStock CC = new TabStock();
           Response.Add(CC.GetList(CC));
            TabProveedor PP = new TabProveedor();
            Response.Add(PP.Get(PP));
            TabCompra CP = new TabCompra();
            Response.Add(CP.GetList(CP));
            TabDetalleCompra DC = new TabDetalleCompra();
            Response.Add(DC.GetList(DC));
            return Response;

        }
    }
}

