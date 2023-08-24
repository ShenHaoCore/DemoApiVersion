using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersion2.Controllers.V1
{
    /// <summary>
    /// 测试
    /// </summary>
    [ApiVersion(1.0)]
    public class TastController : BaseApiController
    {
        /// <summary>
        /// GET
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Get()
        {
            return Content("测试1");
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post()
        {
            return Content("测试1");
        }
    }
}
