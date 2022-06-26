using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using capa_negocio;
using Newtonsoft.Json;

namespace test_project.lib.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ConfiggController : ControllerBase
    {
        [HttpPost]

        public object SaveConfig(object ObjInst)
        {
            TabConfiguracion Inst = JsonConvert.DeserializeObject<TabConfiguracion>(ObjInst.ToString());
            Inst.Save(Inst);
            return true;
        }
        [HttpPost]
        public object GetConfig()
        {
            TabConfiguracion Inst = new TabConfiguracion();
            return Inst.Get(Inst);
        }
    }
}
