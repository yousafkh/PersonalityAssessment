using Core.Data;
using Core.Utility;
using Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class AssessmentController : Controller
    {
        private readonly AppDbContext _context;
        public AssessmentController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> PersonalityTest()
        {
            var questions = await _context.Questions
                .Include(x => x.Options)
                .AsNoTracking()
                .ToListAsync();

            ICollection<ViewPersonalityTestVM> personalityTestVMs = new List<ViewPersonalityTestVM>();

            foreach (var question in questions)
            {
                ViewPersonalityTestVM ptVM = new ViewPersonalityTestVM
                {
                    QuestionId = question.QuestionId,
                    QuestionDescription = question.Description,
                };

                foreach (var option in question.Options)
                {
                    OptionsVM optionVM = new OptionsVM
                    {
                        OptionId = option.OptionId,
                        OptionDescription = option.Description
                    };
                    ptVM.Options.Add(optionVM);
                }

                personalityTestVMs.Add(ptVM);
            }

            return View(personalityTestVMs);
        }


        [HttpPost]
        public async Task<IActionResult> PersonalityTest([FromBody] List<CreatePersonalityTestVM> createPersonalityTestVM)
        {
            ResponseFormat response = new ResponseFormat { value = createPersonalityTestVM };

            if (createPersonalityTestVM == null || createPersonalityTestVM.Count == 0)
            {
                response.status = false; response.message = "Form not filled correctly";
            }
            else
            {
                response.status = true;
                // calculate score for the user

                var questions = await _context.Questions.Include(x => x.Options).ToListAsync();

                int introvert = 0, extrovert = 0;

                foreach (var userAnswers in createPersonalityTestVM)
                {
                    var question = questions.SingleOrDefault(x => x.QuestionId == userAnswers.QuestionId);

                    if (question == null) { continue; }

                    var option = question.Options.SingleOrDefault(x => x.OptionId == userAnswers.OptionId);

                    if (option == null) { continue; }


                    if (option.PersonalityTrait == Core.Constants.PersonalityTrait.Introvert)
                    {
                        introvert += option.Weightage;
                    }
                    else if (option.PersonalityTrait == Core.Constants.PersonalityTrait.Extrovert)
                    {
                        extrovert += option.Weightage;
                    }

                }

                if (introvert == extrovert) { response.message = "equal"; }
                else if (introvert > extrovert) { response.message = "introvert"; }
                else { response.message = "extrovert"; }
            }

            return new JsonResult(response);
        }
    }
}

