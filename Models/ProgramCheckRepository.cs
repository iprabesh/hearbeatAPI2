using System.Collections.Generic;

namespace heartBeatServerAPI.Models
{
    public class ProgramCheckRepository : IProgramCheckRepository
    {
        private List<programCheck> programChecks = new List<programCheck>();
        private int _nextId = 1;

        public ProgramCheckRepository(){
            Add(new programCheck {programName="notepad.exe", programCount=0, programLimit=2});
        }


        public programCheck Add(programCheck item)
        {
            if (item == null)
            {
               // throw new ArgumentNullException("item");
            }

            item.Id = _nextId++;
            programChecks.Add(item);
            return item;
        }

        public programCheck Get(int id)
        {
            return programChecks.Find(p => p.Id == id);
        }

        public IEnumerable<programCheck> GetAll()
        {
            return programChecks;
        }
/* 
        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }
*/
         public bool Update(programCheck item)
        {
            if (item == null)
            {
               // throw new ArgumentNullException("item");
            }
            int index = programChecks.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            programChecks.RemoveAt(index);
            programChecks.Add(item);
            return true;
        } 
    }
}