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
    public class ProducController : ControllerBase
    {
        #region TabProducto
        [HttpPost]
        public object Saveproduc(object ObjIns)
        {
            TabProducto Ins = JsonConvert.DeserializeObject<TabProducto>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public object GetProductos()
        {
            List<Object> Response = new List<object>();

            TabProducto CC = new TabProducto();
            Response.Add(CC.Get(CC));
            CatCategoria CP = new CatCategoria();
            Response.Add(CP.GetList(CP));
            return Response;

        }
        #endregion

    }
}
