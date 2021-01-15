using System.Collections.Generic;

namespace Bibliotheque_Repositories
{
    public interface INovelsService<Tentity>
    {
        void Add(Tentity n);
        void Delete(int id);
        IEnumerable<Tentity> GetAll();
        Tentity GetOne(int id);
        void Update(int id,Tentity n);
    }
}