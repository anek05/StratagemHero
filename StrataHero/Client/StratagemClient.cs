using System.Text.Json;

namespace StrataHero;

public class StratagemClient
{
    string filepath = "data/StratagemCodes.json";

    public List<Stratagem> GetStratagems()
    {
        string jsonString = File.ReadAllText(filepath);

        var stratagems = JsonSerializer.Deserialize<List<Stratagem>>(jsonString);
        return stratagems;
    }
}
