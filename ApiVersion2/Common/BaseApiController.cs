using Microsoft.AspNetCore.Mvc;

namespace ApiVersion2
{
    /// <summary>
    /// 基础控制器
    /// </summary>
    [ApiController]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class BaseApiController : ControllerBase
    {
    }
}
