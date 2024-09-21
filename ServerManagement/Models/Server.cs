namespace ServerManagement.Models;

public class Server
{
    public int Id { get; set; }
    public bool IsOnline { get; set; }
    public string Name { get; set; }
    public string City { get; set; }

    public Server()
    {
        IsOnline = new Random().Next(0, 2) == 0;
    }

    public string GetStatusString() =>
        IsOnline ? "Online" : "Offline";
}
