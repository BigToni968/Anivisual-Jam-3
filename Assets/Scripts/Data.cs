

public class Data
{
    static Data _instance = null;
    DataTemp _json = new DataTemp();
    public DataTemp json { get => _json; set => _json = value; }

    Data() { }

    public static Data getInstance()
    {
        if (_instance == null)
            _instance = new Data();

        return _instance;
    }
}
