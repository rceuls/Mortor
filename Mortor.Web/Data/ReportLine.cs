using System;
using System.ComponentModel.DataAnnotations;

namespace Mortor.Web.Data
{
    public class ReportLine
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ReportId { get; set; }
        
        [Required]
        public string Responsible { get; set; }

        [Required]
        public string Description { get; set; }
        
        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public string Location { get; set; }
        
        public string ImagePath { get; set; }
    }
}