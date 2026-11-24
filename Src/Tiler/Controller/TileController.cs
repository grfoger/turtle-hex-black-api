using Microsoft.AspNetCore.Mvc;
using Tiler.Contract;

namespace Tiler.Controller;

[ApiController]
[Route("/tile")]
public class TileController
{
    private readonly ITileService _tileService;
    public TileController(ITileService tileService)
    {
        _tileService = tileService;
    }
    [HttpGet]
    public string Get()
    {
        return "Hello World!";
    }
    
    [HttpGet("/field-by-id/{parentId}")]
    public string GetTilesByParentId([FromRoute]string parentId)
    {
        _tileService.GetTilesFiledByParentId(parentId);
        return "Hello World!";
    }
}