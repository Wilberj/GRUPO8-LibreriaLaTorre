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
    public class BodegController : ControllerBase
    {

        [HttpPost]
        public object SaveBodega(Object ObjIns)
        {
            TabBodega Ins = JsonConvert.DeserializeObject<TabBodega>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }

        [HttpGet]
        public object GetBodega()
        {
            TabBodega Ins = new TabBodega();
            return Ins.GetList(Ins);
        }
    }
}
