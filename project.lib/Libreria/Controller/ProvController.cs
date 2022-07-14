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
    public class ProvController : ControllerBase
    {
        [HttpPost]
        public object SaveProv(Object ObjIns)
        {
            TabProveedor Ins = JsonConvert.DeserializeObject<TabProveedor>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }

        [HttpGet]
        public object GetProv()
        {
            TabProveedor Ins = new TabProveedor();
            return Ins.Get(Ins);
        }
    }
}
