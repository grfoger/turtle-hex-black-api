namespace Tiler.Contract;

public interface ITileAddress
{
    int Line { get; }
    int Position { get; }
    string GetName();
    (float x, float y) CalculateCoordinates(int hexSize);
}