using System.Collections.Generic;

namespace heartBeatServerAPI.Models
{
    public interface IProgramCheckRepository
    {
     IEnumerable<programCheck> GetAll();
        programCheck Get(int id);
        programCheck Add(programCheck item);
       /*  void Remove(int id);
       */
        bool Update(programCheck item);  
    }
}