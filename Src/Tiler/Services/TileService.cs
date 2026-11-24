using Tiler.Contract;
using Tiler.Model;

namespace Tiler.Services;

public record struct TilePosition(int Line, int Position);
public class TileService : ITileService
{
    // это существующие адреса, мы по адерсу получаем соседа и проверям сегнереирован он уже или нет
    // todo сюда надо накидать соседей из соседних родительских гексов
    private readonly IReadOnlyDictionary<TilePosition, Tile?> _actualHexState;
    public TileService()
    {
        // базовая инициализация адресов пустого поля без значений
        // todo надо переписать. отдельно коллекция адресов которая генерится на стартке как константа
        // todo и отдельно под запрос генерации словарь с гексами
        _actualHexState = TileStatsHelper.AllPositions.ToDictionary(t => t, _ => (Tile?) null);
    }
    
    public IReadOnlyCollection<Tile> GetTilesFiledByParentId(string parentId)
    {
        Console.WriteLine($"Здесь будет передаваться параметр {parentId}");
        // проверка наличия в базе данных, если нет то получаем
        // параметры родительского гекса и по нему генерируем новое поле
        // и пишем в базу данных
        return GenerateTiles();
    }

    private IReadOnlyCollection<Tile> GenerateTiles()
    {
        
        // todo концепция генерации 
        // начинаем от края к центру
        // если соседних гексов ещё нет, то берётся соседний родиельский гекс для родительского гекса текущего поля, с повышенной вероятность случайных значений
        // таким образом следует разделать фоновоую доп вероятность и вероятность от соседних гексов и множетили для них
        // к каждому гексу добавляется доп вероятность от биома родительского гекса ( возможно к центру больше)

        return TileStatsHelper.AllPositions.Select(p => Tile.Create(p.Line, p.Position, GetRandomBiome())).ToList();
    }

    private BiomeType GetRandomBiome()
    {
        var values = Enum.GetValues<BiomeType>();
        return (BiomeType)values.GetValue(Random.Shared.Next(values.Length))!;
    }
}