using Microsoft.AspNetCore.Mvc;

namespace ApiVersion1.Controllers
{
    /// <summary>
    /// 测试
    /// </summary>
    public class Tast1Controller : BaseApiController
    {
        /// <summary>
        /// GET
        /// </summary>
        /// <returns></returns>
        [ApiExplorerSettings(GroupName = nameof(FrameworkEnum.ApiVersion.V1))]
        [HttpGet]
        public ActionResult Get()
        {
            return Content("测试");
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <returns></returns>
        [ApiExplorerSettings(GroupName = nameof(FrameworkEnum.ApiVersion.V1))]
        [HttpPost]
        public ActionResult Post()
        {
            return Content("测试");
        }
    }
}
