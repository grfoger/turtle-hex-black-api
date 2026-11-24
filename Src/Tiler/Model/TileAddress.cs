using Tiler.Contract;

namespace Tiler.Model;

public class TileAddress(int line, int position) : ITileAddress
{
    public int Line { get; } = line;
    public int Position { get; } = position;
    public string GetName()
    {
        throw new NotImplementedException();
    }

    public (float x, float y) CalculateCoordinates(int hexSize)
    {
        // здесь вычисляем реальные координаты в завиисмоти от размера гекса
        // в другом месте к ним массово добавляется смещение от центра
        // где то надо будет добавить смещение для отрисовки parrent гексво в зависимости от размера ячейки гекса
        throw new NotImplementedException();
    }
}