using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersion2.Controllers.V2
{
    /// <summary>
    /// 测试
    /// </summary>
    [ApiVersion(2.0)]
    public class TastController : BaseApiController
    {
        /// <summary>
        /// GET
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Get()
        {
            return Content("测试2");
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post()
        {
            return Content("测试2");
        }
    }
}
