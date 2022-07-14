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
    public class UserController : ControllerBase
    {
        [HttpPost]
        public object SaveUser(Object ObjIns)
        {
            TabUsuario Ins = JsonConvert.DeserializeObject<TabUsuario>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public object GetUser()
        {
            TabUsuario Ins = new TabUsuario();
            return Ins.GetList(Ins);
        }
    }
}
