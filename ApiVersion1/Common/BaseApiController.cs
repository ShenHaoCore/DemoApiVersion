﻿using Microsoft.AspNetCore.Mvc;

namespace ApiVersion1
{
    /// <summary>
    /// 基础控制器
    /// </summary>
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class BaseApiController : ControllerBase
    {
    }
}
