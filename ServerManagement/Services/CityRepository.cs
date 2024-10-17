namespace ServerManagement.Services;

public class CityRepository
{
    private static readonly List<string> _cities =
    [
        "Toronto",
        "Montreal",
        "Ottawa",
        "Calgary",
        "Halifax"
    ];

    public static List<string> GetAll() => _cities;
}
