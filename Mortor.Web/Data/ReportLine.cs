using System;
using System.ComponentModel.DataAnnotations;

namespace Mortor.Web.Data
{
    public class ReportLine
    {
        [Key]
        public string Id { get; set; }
        
        [Required]
        public string Responsible { get; set; }

        [Required]
        public string Description { get; set; }
        
        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public string Location { get; set; }
        
        [Required]
        public string ImagePath { get; set; }
    }
}