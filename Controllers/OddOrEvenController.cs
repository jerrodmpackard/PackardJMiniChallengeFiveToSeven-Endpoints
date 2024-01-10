using Microsoft.AspNetCore.Mvc;
using PackardJMiniChallengeFiveToSeven_Endpoints.Services.OddOrEven;

namespace PackardJMiniChallengeFiveToSeven_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : Controller
{
    private readonly IOddOrEvenService _oddOrEvenService;

    public OddOrEvenController(IOddOrEvenService oddOrEvenService)
    {
        _oddOrEvenService = oddOrEvenService;
    }

    [HttpGet]
    [Route("OddOrEven/{number}")]
    public string OddOrEven(string number)
    {
        return _oddOrEvenService.OddOrEven(number);
    }
}
