using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid QuestionId { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<QuestionOptions> Options { get; set; }
    }
}
