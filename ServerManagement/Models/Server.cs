using System.ComponentModel.DataAnnotations;

namespace ServerManagement.Models;

public class Server
{
    [Required]
    [Range(0, int.MaxValue)]
    public int Id { get; set; }
    
    public bool IsOnline { get; set; }

    [Required(AllowEmptyStrings = false)]
    [MaxLength(20)]
    public string Name { get; set; }

    [Required(AllowEmptyStrings = false)]
    [MaxLength(20)]
    public string City { get; set; }

    public Server()
    {
        IsOnline = new Random().Next(0, 2) == 0;
    }

    public string GetStatusString() =>
        IsOnline ? "Online" : "Offline";
}
