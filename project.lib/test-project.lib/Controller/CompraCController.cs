using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using capa_negocio;
using Newtonsoft.Json;

namespace test_project.lib.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompraCController : ControllerBase
    {
        [HttpPost]

        public object SaveCompra(object ObjInst)
        {
            TabCompra Inst = JsonConvert.DeserializeObject<TabCompra>(ObjInst.ToString());
            Inst.Save(Inst);
            return true;
        }
        [HttpPost]
        public object GetCompra()
        {
            TabCompra Inst = new TabCompra();
            return Inst.Get(Inst);
        }
    }
}
