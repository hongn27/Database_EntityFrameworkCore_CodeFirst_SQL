using ConsoleApp.Entities;
using ConsoleApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services;

internal class ManufactureService
{
    private readonly ManufactureRepository _manufactureRepository;

    public ManufactureService(ManufactureRepository manufactureRepository)
    {
        _manufactureRepository = manufactureRepository;
    }

    public ManufactureEntity GetManufactureByManufactureName(string manufactureName)
    {
        var manufactureEntity = _manufactureRepository.Get(x => x.ManufactureName == manufactureName);
        return manufactureEntity;
    }

    public ManufactureEntity GetManufactureById(int id)
    {
        var manufactureEntity = _manufactureRepository.Get(x => x.Id == id);
        return manufactureEntity;
    }

    public IEnumerable<ManufactureEntity> GetManufactures()
    {
        var manufactures = _manufactureRepository.GetAll();
        return manufactures;
    }

    public ManufactureEntity UpdateManufacture(ManufactureEntity manufactureEntity)
    {
        var updatedManufactureEntity = _manufactureRepository.Update(x => x.Id == manufactureEntity.Id, manufactureEntity);
        return updatedManufactureEntity;
    }

    public void DeleteManufacture(int id)
    {
        _manufactureRepository.Detele(x => x.Id == id);
    }

    public ManufactureEntity CreateManufacture(string manufactureName)
    {
      
        return _manufactureRepository.Create(new ManufactureEntity { ManufactureName = manufactureName });

    }
}
