using TeaJournal.Model;

namespace TeaJournal.Services

{
    public class TeaJournalCrudService
    {
        public TeaJournalCrudService() { }

        private List<Tea> TeaList { get; set; }

        public IEnumerable<Tea> GetTeaList() 
        {
            return TeaList; 
        }

        public IEnumerable<Tea> GetTeaById(int id)
        {
            return TeaList;
        }

        public IEnumerable<Tea> AddTea(Tea tea)
        {
            return;
        }

        public IEnumerable<Tea> UpdateTea(Tea tea) 
        {

        }
    }
}
