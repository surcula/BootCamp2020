using System.Collections.Generic;

namespace Bibliotheque_Repositories
{
    public interface IUserService<Tentity>
    {
        void Delete(int id);
        IEnumerable<Tentity> GetAll();
        Tentity GetOne(int id);
        void Insert(Tentity u);
        void Update(Tentity u);
    }
}