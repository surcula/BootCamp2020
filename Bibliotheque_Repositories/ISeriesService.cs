using System.Collections.Generic;

namespace Bibliotheque_Repositories
{
    public interface ISeriesService<Tentity>
    {
        void Add(Tentity s);
        IEnumerable<Tentity> GetAll();
        Tentity GetOne(int id);
        void Update(int id, Tentity s);
        
    }
}