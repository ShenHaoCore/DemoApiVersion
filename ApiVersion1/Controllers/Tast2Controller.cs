using Microsoft.AspNetCore.Mvc;

namespace ApiVersion1.Controllers
{
    /// <summary>
    /// 测试
    /// </summary>
    [ApiExplorerSettings(GroupName = nameof(FrameworkEnum.ApiVersion.V2))]
    public class Tast2Controller : BaseApiController
    {
        /// <summary>
        /// GET
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Get()
        {
            return Content("测试");
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post()
        {
            return Content("测试");
        }
    }
}
