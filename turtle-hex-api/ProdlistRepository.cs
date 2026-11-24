namespace turtle_hex_api;


public class ProdlistRepository
{
    private IReadOnlyCollection<ProdlistModel> _prodlist = Array.Empty<ProdlistModel>();

    public IReadOnlyCollection<string> Load()
    {
        return _prodlist.Select(i => i.Item).ToArray();
    }

    public void Save(IReadOnlyCollection<string> list4Save)
    {
        _prodlist = list4Save.Select(i => new ProdlistModel(i)).ToArray();
    }
}