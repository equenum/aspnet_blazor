using ServerManagement.Models;

namespace ServerManagement.DataAccess;

public static class ServersRepository
{
    private static readonly List<Server> _servers =
    [
        new Server {  Id = 1,Name = "Server1", City = "Toronto" },
        new Server {  Id = 2, Name = "Server2", City = "Toronto" },
        new Server {  Id = 3, Name = "Server3", City = "Toronto" },
        new Server {  Id = 4, Name = "Server4", City = "Toronto" },
        new Server {  Id = 5, Name = "Server5", City = "Montreal" },
        new Server {  Id = 6, Name = "Server6", City = "Montreal" },
        new Server {  Id = 7, Name = "Server7", City = "Montreal" },
        new Server {  Id = 8, Name = "Server8", City = "Ottawa" },
        new Server {  Id = 9, Name = "Server9", City = "Ottawa" },
        new Server {  Id = 10, Name = "Server10", City = "Calgary" },
        new Server {  Id = 11, Name = "Server11", City = "Calgary" },
        new Server {  Id = 12, Name = "Server12", City = "Halifax" },
        new Server {  Id = 13, Name = "Server13", City = "Halifax" }            
    ];

    public static List<Server> GetServers() => _servers;

    public static List<Server> GetServersByCity(string cityName) =>
        _servers.Where(s => s.City.Equals(cityName, StringComparison.OrdinalIgnoreCase))
            .ToList();

    public static Server GetServerById(int id) =>
        _servers.FirstOrDefault(s => s.Id == id);

    public static List<Server> SearchServers(string serverFilter) =>
        _servers.Where(s => s.Name.Contains(serverFilter, StringComparison.OrdinalIgnoreCase))
            .ToList();
    public static void AddServer(Server server)
    {
        var maxId = _servers.Max(s => s.Id);
        server.Id = maxId + 1;

        _servers.Add(server);
    }

    public static void UpdateServer(int serverId, Server server)
    {
        if (serverId != server.Id) return;

        var serverToUpdate = _servers.FirstOrDefault(s => s.Id == serverId);
        if (serverToUpdate != null)
        {
            serverToUpdate.IsOnline = server.IsOnline;
            serverToUpdate.Name = server.Name;
            serverToUpdate.City = server.City;
        }
    }

    public static void DeleteServer(int serverId)
    {
        var server = _servers.FirstOrDefault(s => s.Id == serverId);
        if (server != null)
        {
            _servers.Remove(server);
        }
    }

    public static void DeleteServer(Server server)
    {
        DeleteServer(server.Id);
    }
}
