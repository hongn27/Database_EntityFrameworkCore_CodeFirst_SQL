using System.ComponentModel.DataAnnotations;

namespace ConsoleApp.Entities;

internal class ManufactureEntity
{
    [Key]
    public int Id { get; set; }
    public string ManufactureName { get; set; }  = null!;
}
