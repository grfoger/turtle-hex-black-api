using System;

namespace turtle_hex_api;

public class ProdlistModel
{
    public ProdlistModel(string item)
    {
        Item = item;
    }
    public string Item { get; }
}