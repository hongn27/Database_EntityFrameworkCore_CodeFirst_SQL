using ConsoleApp.Context;
using ConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq.Expressions;

namespace ConsoleApp.Repositories;

internal class UserRepository : Repo<UserEntity>
{

    private readonly DataContext _context;
    public UserRepository(DataContext context) : base(context)
    {
        _context = context;
    }

    public override UserEntity Get(Expression<Func<UserEntity, bool>> expression)
    {
        return base.Get(expression);
    }

    public override IEnumerable<UserEntity> GetAll()
    {
        return _context.Users
            .Include(i  => i.Address)
            .Include(i => i.Role)
            .ToList();
    }
}