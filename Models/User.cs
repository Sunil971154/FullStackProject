﻿using System.ComponentModel.DataAnnotations;

namespace Revision_Project.Models
{
    public class User
    {
        [Key]
        public int? Id { get; set; } // SQL Server में ज्यादातर int primary key होता है, लेकिन आप GUID भी use कर सकते हैं


        [Required] // EF Core में सीधे attribute से नहीं होता, नीचे Fluent API में दिखाते हैं
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        // Navigation property       
        public List<JournalEntry2> JournalEntries { get; set; } = new();   // journal entry k referance hold karegi 

    }
}
