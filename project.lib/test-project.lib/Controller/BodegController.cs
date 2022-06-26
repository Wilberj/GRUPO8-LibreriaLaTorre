using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using capa_negocio;

namespace test_project.lib.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BodegController : ControllerBase
    {
        [HttpPost]

        public object SaveBodega(object ObjInst)
        {
            TabBodega Inst = JsonConvert.DeserializeObject<TabBodega>(ObjInst.ToString());
            Inst.Save(Inst);
            return true;
        }
        [HttpPost]
        public object GetBodega()
        {
            TabBodega Inst = new TabBodega();
            return Inst.Get(Inst);
        }

    }
}
