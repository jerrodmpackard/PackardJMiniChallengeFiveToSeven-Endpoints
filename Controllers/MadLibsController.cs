using Microsoft.AspNetCore.Mvc;
using PackardJMiniChallengeFiveToSeven_Endpoints.Services.MadLibs;

namespace PackardJMiniChallengeFiveToSeven_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibsController : Controller
{
    private readonly IMadLibsService _madLibsService;

    public MadLibsController(IMadLibsService madLibsService)
    {
        _madLibsService = madLibsService;
    }

    [HttpGet]
    [Route("MadLibs/{heroName}/{planetName}/{speciesName}/{pluralNoun}/{noun5}/{noun6}/{verb1}/{verb2}/{adj1}/{adj2}")]
    public string MadLibs(string heroName, string planetName, string speciesName, string pluralNoun, string noun5, string noun6, string verb1, string verb2, string adj1, string adj2)
    {
        return _madLibsService.MadLibs(heroName, planetName, speciesName, pluralNoun, noun5, noun6, verb1, verb2, adj1, adj2);
    }
}
