using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Revision_Project.Interface;
using Revision_Project.Models;

namespace Revision_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JournalEntryController : ControllerBase
    {

        private readonly IJERepository _repository;

        public JournalEntryController(IJERepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<JournalEntry2>>> GetAll()
        {
            var entries = await _repository.GetAll(); // 🔁 Repository se saare journal entries laao
            if (entries == null || !entries.Any())
            {
                return NotFound("No journal entries found."); // ❌ 404 Not Found with message
            }

            return Ok(entries); // ✅ HTTP 200 OK ke saath list return karo
        }

        [HttpGet("id/{id}")]
        public async Task<ActionResult<JournalEntry2>> GetById(int id)
        {
            var entry = await _repository.GetById(id); // 🔍 ID ke basis pe ek entry fetch karo
            if (entry == null) return NotFound(); // ❌ Agar nahi mili to 404 bhejo
            return Ok(entry); // ✅ Entry mili to OK return karo
        }

        [HttpPost]
        public async Task<ActionResult<JournalEntry2>> Create([FromBody] JournalEntry2 entry)
        {
            if (entry == null) // ❗ Client ne null bheja to bad request bhejo
                return BadRequest("Invalid data.");

            var saved = await _repository.SaveEntry(entry); // 💾 Repository se new entry save karo
            return Ok(saved); // ✅ Save hone ke baad OK return karo
        }

        [HttpPut("id/{id}")]
        public async Task<ActionResult<JournalEntry2>> Update(int id, [FromBody] JournalEntry2 entry)
        {
            var updated = await _repository.UpdateById(id, entry); // 🔁 Existing entry update karo
            if (updated == null) return NotFound(); // ❌ Entry nahi mili to 404 return karo
            return Ok(updated); // ✅ Update hone ke baad OK return karo
        }

        [HttpDelete("id/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _repository.DeleteById(id); // 🗑️ Entry ko delete karo
            if (deleted == null) return NotFound(); // ❌ Entry na mile to NotFound
            return Ok("Deleted successfully"); // ✅ Successfully delete message bhejo
        }







    }
}
