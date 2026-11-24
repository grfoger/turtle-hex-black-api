using Tiler.Model;

namespace Tiler.Contract;

public interface ITileService
{
    IReadOnlyCollection<Tile> GetTilesFiledByParentId(string parentId);
}