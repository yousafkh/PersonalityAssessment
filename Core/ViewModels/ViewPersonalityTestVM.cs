using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class ViewPersonalityTestVM
    {
        public Guid QuestionId { get; set; }
        public string QuestionDescription { get; set; }
        public ICollection<OptionsVM> Options { get; set; } = new List<OptionsVM>();
        public Guid SelectedOptionId { get; set; }
    }

    public class OptionsVM
    {
        public Guid OptionId { get; set; }
        public string OptionDescription { get; set; }
    }
}
