using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp.Entities;

internal class ProductEntity
{
    [Key]
    public int Id { get; set; }
    public int ArticleNumber { get; set; } = 0;
    public string Title { get; set; } = null!;
    public string Ingress { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }


    public int ManufactureID { get; set; } 
    public ManufactureEntity Manufacture { get; set; } = null!;


    public int CategoryID { get; set; }
    public CategoryEntity Category { get; set; } = null!;

}
