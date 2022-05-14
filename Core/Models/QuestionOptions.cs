using Core.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class QuestionOptions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OptionId { get; set; }
        public Guid QuestionId { get; set; }
        public PersonalityTrait PersonalityTrait { get; set; }
        public byte Weightage { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
