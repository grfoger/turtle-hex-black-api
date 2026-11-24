namespace Tiler.Model;

public class TileId
{
    public Guid Value { get; }
    public TileId(Guid value)
    {
        Value = value;
    }

    public static TileId GenerateNew()
    {
        return new TileId(Guid.NewGuid());
    }
}