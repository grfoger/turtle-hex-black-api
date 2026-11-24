using Tiler.Contract;

namespace Tiler.Model;

public class Tile
{

    private Tile(
        TileId id,
        TileId? parentId,
        ITileContent content,
        ITileAddress address,
        TileScaleLevel scaleLevel
        )
    {
        Id = id;
        ParentId = parentId;
        Content = content;
        Address = address;
        ScaleLevel = scaleLevel;
    }

    public static Tile Create(int line, int position, BiomeType biomeType)
    {
        return new Tile(
            TileId.GenerateNew(),
            null,
            new TileContent(biomeType),
            new TileAddress(line, position),
            TileScaleLevel.Sector
            );
    }
    public TileId Id { get; set; }
    
    public TileId? ParentId { get; set; }

    public Dictionary<NearbyTilePosition, TileId> NearbyTileIds { get; set; } = new();
    
    public ITileContent Content { get; set; }
    
    public ITileAddress Address { get; set; }
    
    public TileScaleLevel ScaleLevel { get; set; }
}