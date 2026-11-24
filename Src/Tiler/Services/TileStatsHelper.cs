using Tiler.Model;

namespace Tiler.Services;

public static class TileStatsHelper
{
    public static TilePosition[] GenTurn1 = [
        new (-6, -2),
        new (-5, -5),
        new (-4, -8),
        new (6, -2),
        new (5, -5),
        new (4, -8),
        new (-2, 10),
        new (0, 10),
        new (2, 10),
    ];
    
    public static TilePosition[] GenTurn2 = [
        new (-3, 9), new (3, 9),
        new (-4, 6), new (4, 6),
        new (-5, 3), new (5, 3),
        new (-6, 0), new (6, 0),
        new (-5, -3), new (5, -3),
        new (-4, -6), new (4, -6),
        new (-3, -9), new (3, -9),
        new (-1, 9), new (1, 9),
        new (-1, -9), new (1, -9),
    ];

    public static TilePosition[] GenTurn3 = [
        new (-2, 8), new (0, 8), new (2, 8),
        new (-3, 7), new (3, 7),
        new (-4, 4), new (4, 4),
        new (-5, 1), new (5, 1),
        new (-5, -1), new (5, -1),
        new (-4, -4), new (4, -4),
        new (-3, -7), new (3, -7),
        new (-2, -8), new (0, -8), new (2, -8),
    ];
    
    public static TilePosition[] GenTurn4 = [
        new (-1, 7), new (1, 7),
        new (-3, 5), new (3, 5),
        new (-4, 2), new (4, 2),
        new (-4, -2), new (4, -2),
        new (-3, -5), new (3, -5),
        new (-1, -7), new (1, -7)
    ];

    public static TilePosition[] GenTurn5 = [
        new (-2, 6), new (0, 6), new (2, 6),
        new (-3, 3), new (3, 3),
        new (-4, 0), new (4, 0),
        new (-3, -3), new (3, -3),
        new (-2, -6), new (0, -6), new (2, -6),
    ];

    public static TilePosition[] GenTurn6 = [
        new (-1, 5), new (1, 5),
        new (-2, 4), new (2, 4),
        new (-3, 1), new (3, 1),
        new (-3, -1), new (3, -1),
        new (-2, -4), new (2, -4),
        new (-1, -5), new (1, -5),
    ];

    public static TilePosition[] GenTurn7 = [
        new (0, 4),  new (-1, 3), new (1,3),
        new (-2, 2), new (2, 2),
        new (-2, 0), new (2, 0),
        new (-2, -2), new (2, -2),
        new (0, -4),  new (-1, -3), new (1,-3),
    ];

    public static TilePosition[] GenTurnCantral = [
        new (-1, 1), new (0, 2), new (1, 1),
        new (-1, -1), new (0, -2), new (1, -1),
        new (0, 0) // Финальная точка
    ];
    
    public static TilePosition[] NearbyA = [
        new (-2, 12), new (0, 12), new (2, 12),
        new (-3, 11), new (-1, 11), 
        new (3, 11), new (1, 11), 
    ];
    
    public static TilePosition[] NearbyB = [
        new (4, 10), new (4, 8), 
        new (5, 7),  new (5, 5),
        new (6, 4), new (6, 2), 
        new (7, 1),
    ];
    
    public static TilePosition[] NearbyC = [
        new (7, -1), new (7, -3), 
        new (6, -4),  new (6, -6),
        new (5, -7), new (5, -9), 
        new (4, -10),
    ];
    
    public static TilePosition[] NearbyD = [
        new (-2, -12), new (0, -12), new (2, -12),
        new (-3, -11), new (-1, -11), 
        new (3, -11), new (1, -11),
    ];
    
    public static TilePosition[] NearbyE = [
        new (-7, -1), new (-7, -3), 
        new (-6, -4),  new (-6, -6),
        new (-5, -7), new (-5, -9), 
        new (-4, -10),
    ];
    
    public static TilePosition[] NearbyF = [
        new (-4, 10), new (-4, 8), 
        new (-5, 7),  new (-5, 5),
        new (-6, 4), new (-6, 2), 
        new (-7, 1),
    ];

    public static TilePosition[][] AllTurns =
    [
        GenTurn1,
        GenTurn2,
        GenTurn3,
        GenTurn4,
        GenTurn5,
        GenTurn6,
        GenTurn7,
        GenTurnCantral
    ];

    public static TilePosition[] AllPositions =
    [
        ..GenTurn1,
        ..GenTurn2,
        ..GenTurn3,
        ..GenTurn4,
        ..GenTurn5,
        ..GenTurn6,
        ..GenTurn7,
        ..GenTurnCantral
    ];
}