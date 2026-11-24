namespace Tiler.Model;

public enum NearbyTilePosition
{
    A, // первый соседний тайл: либо верхний, либо левый из верхних относительно центрального
    B, // следующи по часовой стрелке
    C,
    D,
    E,
    F // последний
}