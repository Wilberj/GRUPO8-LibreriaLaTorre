using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using capa_negocio;
using Newtonsoft.Json;

//MetodoCategoria 
namespace test_project.lib.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategController : ControllerBase
    {
        [HttpPost]

        public object SaveCategoria(object ObjInst)
        {
            CatCategoria Inst = JsonConvert.DeserializeObject<CatCategoria>(ObjInst.ToString());
            Inst.Save(Inst);
            return true;
        }
        [HttpPost]
        public object GetCategoria()
        {
            CatCategoria Inst = new CatCategoria();
            return Inst.Get(Inst);
        }
    }
}
