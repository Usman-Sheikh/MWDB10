using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelsDemo.Models
{
    public class Session
    {
        public int SessionID { get; set; }
        [Required]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name ="Session Date")]
        public DateTime? SesssionDate { get; set; }
        public virtual Speaker Speaker { get; set; }


    }
}