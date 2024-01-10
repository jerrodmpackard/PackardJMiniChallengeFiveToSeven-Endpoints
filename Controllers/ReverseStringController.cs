using Microsoft.AspNetCore.Mvc;
using PackardJMiniChallengeFiveToSeven_Endpoints.Services.ReverseString;

namespace PackardJMiniChallengeFiveToSeven_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseStringController : Controller
{
    private readonly IReverseStringService _reverseStringService;

    public ReverseStringController(IReverseStringService reverseStringService)
    {
        _reverseStringService = reverseStringService;
    }

    [HttpGet]
    [Route("ReverseString/{word}")]
    public string ReverseString(string word)
    {
        return _reverseStringService.ReverseString(word);
    }
}
