using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using capa_negocio;
using Newtonsoft.Json;

namespace test_project.lib.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProdController : ControllerBase
    {
        #region Producto
        [HttpPost]
        public object SaveProd(object ObjInst)
        {
            TabProducto Inst = JsonConvert.DeserializeObject<TabProducto>(ObjInst.ToString());
            Inst.Save(Inst);
            return true;
        }
        [HttpPost]
        public object GetProd()
        {
            TabProducto Inst = new TabProducto();
            return Inst.Get(Inst);
        }
        #endregion 
    }
}
