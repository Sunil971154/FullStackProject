using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Revision_Project.Models
{
    public class JournalEntry1
    {
        public long Id { get; set; }      // case matter nahi karta letter chota bada ho dakta hai       
        public string Title { get; set; }
        public string Content { get; set; }


    }
}
