using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mortor.Web.Data
{
    public class Report 
    {
        [Key] public string Id { get; set; }
        
        [Required]
        public string CreatedBy { get; set; }
        
        [Required]
        public DateTime TargetDate { get; set; }

        public List<ReportLine> ReportLines { get; set; }
    }
}