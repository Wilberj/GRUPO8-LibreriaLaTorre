using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using capa_negocio;
using Newtonsoft.Json;


namespace test_project.lib.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]

        public object SaveUser(object ObjInst)
        {
            TabUsuario Inst = JsonConvert.DeserializeObject<TabUsuario>(ObjInst.ToString());
            Inst.Save(Inst);
            return true;
        }
        [HttpPost]
        public object GetUsuario()
        {
            TabUsuario Inst = new TabUsuario();
            return Inst.Get(Inst);
        }
    }
}
