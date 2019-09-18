using System.Collections.Generic;
using DBProject;
using DBProject.DAL;

namespace TestDotNet.Services
{
    public interface IRozTestService
    {
        IUnitOfWork<RozTestEntities> UnitOfWork { get; set; }

        List<Roz> GetAll();
    }
}