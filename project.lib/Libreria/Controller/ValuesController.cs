
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using CAPA_NEGOCIO;
namespace Presentacion.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        #region Categorias
        [HttpPost]
        public object SaveCategory(object ObjIns)
        {
            CatCategoria Ins = JsonConvert.DeserializeObject<CatCategoria>(ObjIns.ToString());
            Ins.Save(Ins);
            return true;
        }
        [HttpGet]
        public object GetCategories()
        {
            CatCategoria Ins = new CatCategoria();            
            return Ins.GetList(Ins);
        }
        #endregion

      

    }
}
