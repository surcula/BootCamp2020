
using System.Collections.Generic;


namespace Bibliotheque_Repositories
{
    public interface ITypesService<Tentity>
    {
        IEnumerable<Tentity> GetAll();
        Tentity GetOne(int id);
        void Insert(Tentity t);
        void Update(int id,Tentity t);
    }
}