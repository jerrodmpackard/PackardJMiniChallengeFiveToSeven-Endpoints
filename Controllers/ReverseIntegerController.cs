using Microsoft.AspNetCore.Mvc;
using PackardJMiniChallengeFiveToSeven_Endpoints.Services.ReverseInteger;

namespace PackardJMiniChallengeFiveToSeven_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseIntegerController : Controller
{
    private readonly IReverseIntegerService _reverseIntegerService;

    public ReverseIntegerController(IReverseIntegerService reverseIntegerService)
    {
        _reverseIntegerService = reverseIntegerService;
    }

    [HttpGet]
    [Route("ReverseInteger/{integer}")]
    public string ReverseInteger(string integer)
    {
        return _reverseIntegerService.ReverseInteger(integer);
    }
}
