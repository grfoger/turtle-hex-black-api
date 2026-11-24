using Microsoft.AspNetCore.Mvc;

namespace turtle_hex_api.Controllers;

[ApiController]
[Route("prodlist")]
public class ProdlistController : ControllerBase
{
    private ProdlistRepository _repository;
    
    public ProdlistController(ProdlistRepository rep)
    {
        _repository = rep;
    }

    [HttpGet]
    public IReadOnlyCollection<string> Load()
    { 
        return _repository.Load();
    }
    
    [HttpPost]
    public void Save([FromBody] IReadOnlyCollection<string> list)
    {
        _repository.Save(list);
    }
}