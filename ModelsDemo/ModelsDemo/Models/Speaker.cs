using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelsDemo.Models
{
    public class Speaker
    {
        public int SpeakerID { get; set; }

        [Required(ErrorMessage ="Speaker Name is required")]
        public string SpeakerName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
    }
}