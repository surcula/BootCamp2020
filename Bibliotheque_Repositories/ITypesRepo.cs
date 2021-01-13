
using System.Collections.Generic;


namespace Bibliotheque_Repositories
{
    public interface ITypesRepo<Tentity>
    {
        IEnumerable<Tentity> GetAll();
        Tentity GetOne(int id);
        void Insert(Tentity t);
        void Update(Tentity t);
    }
}