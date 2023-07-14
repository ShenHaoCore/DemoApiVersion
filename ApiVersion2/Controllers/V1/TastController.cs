using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersion2.Controllers.V1
{
    /// <summary>
    /// 测试
    /// </summary>
    public class TastController : BaseApiController
    {
        /// <summary>
        /// GET
        /// </summary>
        /// <returns></returns>
        [ApiVersion(1.0)]
        [HttpGet]
        public ActionResult Get()
        {
            return Content("测试");
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <returns></returns>
        [ApiVersion(1.0)]
        [HttpPost]
        public ActionResult Post()
        {
            return Content("测试");
        }
    }
}
