using Asp.Versioning;
using Jnr.Technologies.Shared.Common;
using Microsoft.AspNetCore.Mvc;

namespace Jnr.Technologies.Api.Controllers;

[ApiVersion(Constants.Api.VersionOne)]
[Route($"{Constants.Api.RoutePrefix}/[controller]")]
[ApiController]
public class BaseApiController : ControllerBase
{
    
}