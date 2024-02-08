﻿using ConsoleApp.Context;
using ConsoleApp.Entities;

namespace ConsoleApp.Repositories;

internal class ProductRepository : Repo<ProductEntity>
{
    public ProductRepository(DataContext context) : base(context)
    {
    }
}
