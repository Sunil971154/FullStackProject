using Revision_Project.Models;

namespace Revision_Project.Interface
{
    public interface IJERepository
    {
        Task<JournalEntry> SaveEntry(JournalEntry entry);
        Task<JournalEntry> SaveEntryWithUser(JournalEntry entry, string userName);
        Task<List<JournalEntry>> FindAll();
        Task<JournalEntry> FindById(string id);
        Task DeleteById(string id);
    }
}
