using Tiler.Contract;

namespace Tiler.Model;

public class TileContent : ITileContent
{

    public TileContent(BiomeType biomeType)
    {
        Biome = biomeType;
    }
    public BiomeType Biome { get; }
}