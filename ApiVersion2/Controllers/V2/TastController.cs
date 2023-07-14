using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersion2.Controllers.V2
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
        [ApiVersion(2.0)]
        [HttpGet]
        public ActionResult Get()
        {
            return Content("测试");
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <returns></returns>
        [ApiVersion(2.0)]
        [HttpPost]
        public ActionResult Post()
        {
            return Content("测试");
        }
    }
}
