using Revision_Project.Models;

namespace Revision_Project.Interface
{
    public interface IJERepository
    {
        Task<List<JournalEntry2>> GetAll();
        Task<JournalEntry2> GetById(int id);
        Task<JournalEntry2> SaveEntry(JournalEntry2 entry);
        Task<JournalEntry2> UpdateById(int id, JournalEntry2 entry);
        Task<bool> DeleteById(int id);
    }
}
