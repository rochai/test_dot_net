using DBProject;
using DBProject.DAL;
using System.Collections.Generic;
using Unity;

namespace TestDotNet.Services
{
    public class RozTestService : IRozTestService
    {
        [Dependency]
        public IUnitOfWork<RozTestEntities> UnitOfWork { get; set; }

        public List<Roz> GetAll()
        {
            return UnitOfWork.RepositoryFor<Roz>().GetAll();
        }
    }
}