using ConsoleApp.Context;
using ConsoleApp.Entities;

namespace ConsoleApp.Repositories;

internal class ManufactureRepository : Repo<ManufactureEntity>
{
    public ManufactureRepository(DataContext context) : base(context)
    {
    }
}
