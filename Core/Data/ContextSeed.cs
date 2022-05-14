using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public static class ContextSeed
    {
        public static async Task SeedQuestions(AppDbContext context)
        {
            if (!context.Questions.Any())
            {
                // Question 1
                Question q1 = new Question
                {
                    QuestionId = Guid.NewGuid(),
                    Description = "You’re really busy at work and a colleague is telling you their life story and personal woes. You:"
                };

                await context.Questions.AddAsync(q1);

                await context.QuestionOptions.AddAsync(new QuestionOptions
                {
                    Description = "Don’t dare to interrupt them",
                    PersonalityTrait = Constants.PersonalityTrait.Introvert,
                    Weightage = 10,
                    QuestionId = q1.QuestionId,
                });
                await context.QuestionOptions.AddAsync(new QuestionOptions
                {
                    Description = "Think it’s more important to give them some of your time; work can wait",
                    PersonalityTrait = Constants.PersonalityTrait.Introvert,
                    Weightage = 8,
                    QuestionId = q1.QuestionId,
                });
                await context.QuestionOptions.AddAsync(new QuestionOptions
                {
                    Description = "Listen, but with only with half an ear ",
                    PersonalityTrait = Constants.PersonalityTrait.Extrovert,
                    Weightage = 8,
                    QuestionId = q1.QuestionId,
                });
                await context.QuestionOptions.AddAsync(new QuestionOptions
                {
                    Description = "Interrupt and explain that you are really busy at the moment",
                    PersonalityTrait = Constants.PersonalityTrait.Extrovert,
                    Weightage = 10,
                    QuestionId = q1.QuestionId,
                });

                // Question 2
                Question q2 = new Question
                {
                    QuestionId = Guid.NewGuid(),
                    Description = "You’ve been sitting in the doctor’s waiting room for more than 25 minutes. You:"
                };

                await context.Questions.AddAsync(q2);

                await context.QuestionOptions.AddAsync(new QuestionOptions
                {
                    Description = "Look at your watch every two minutes",
                    PersonalityTrait = Constants.PersonalityTrait.Introvert,
                    Weightage = 10,
                    QuestionId = q2.QuestionId,
                });
                await context.QuestionOptions.AddAsync(new QuestionOptions
                {
                    Description = "Bubble with inner anger, but keep quiet",
                    PersonalityTrait = Constants.PersonalityTrait.Introvert,
                    Weightage = 9,
                    QuestionId = q2.QuestionId,
                });
                await context.QuestionOptions.AddAsync(new QuestionOptions
                {
                    Description = "Explain to other equally impatient people in the room that the doctor is always running late",
                    PersonalityTrait = Constants.PersonalityTrait.Extrovert,
                    Weightage = 8,
                    QuestionId = q2.QuestionId,
                });
                await context.QuestionOptions.AddAsync(new QuestionOptions
                {
                    Description = " Complain in a loud voice, while tapping your foot impatiently",
                    PersonalityTrait = Constants.PersonalityTrait.Extrovert,
                    Weightage = 12,
                    QuestionId = q2.QuestionId,
                });

                // Question 3

                Question q3 = new Question
                {
                    QuestionId = Guid.NewGuid(),
                    Description = "You’re having an animated discussion with a colleague regarding a project that you’re in charge of. You:"
                };

                await context.Questions.AddAsync(q3);

                await context.QuestionOptions.AddAsync(new QuestionOptions
                {
                    Description = "Don’t dare contradict them",
                    PersonalityTrait = Constants.PersonalityTrait.Introvert,
                    Weightage = 12,
                    QuestionId = q3.QuestionId,
                });
                await context.QuestionOptions.AddAsync(new QuestionOptions
                {
                    Description = " Think that they are obviously right",
                    PersonalityTrait = Constants.PersonalityTrait.Introvert,
                    Weightage = 10,
                    QuestionId = q3.QuestionId,
                });
                await context.QuestionOptions.AddAsync(new QuestionOptions
                {
                    Description = "Defend your own point of view, tooth and nail",
                    PersonalityTrait = Constants.PersonalityTrait.Extrovert,
                    Weightage = 8,
                    QuestionId = q3.QuestionId,
                });
                await context.QuestionOptions.AddAsync(new QuestionOptions
                {
                    Description = "Continuously interrupt your colleague",
                    PersonalityTrait = Constants.PersonalityTrait.Extrovert,
                    Weightage = 12,
                    QuestionId = q3.QuestionId,
                });

                // Question 4

                Question q4 = new Question
                {
                    QuestionId = Guid.NewGuid(),
                    Description = "You are taking part in a guided tour of a museum. You: "
                };

                await context.Questions.AddAsync(q4);

                await context.QuestionOptions.AddAsync(new QuestionOptions
                {
                    Description = "Are a bit too far towards the back so don’t really hear what the guide is saying",
                    PersonalityTrait = Constants.PersonalityTrait.Introvert,
                    Weightage = 5,
                    QuestionId = q4.QuestionId,
                });
                await context.QuestionOptions.AddAsync(new QuestionOptions
                {
                    Description = "Follow the group without question",
                    PersonalityTrait = Constants.PersonalityTrait.Introvert,
                    Weightage = 5,
                    QuestionId = q4.QuestionId,
                });
                await context.QuestionOptions.AddAsync(new QuestionOptions
                {
                    Description = "Make sure that everyone is able to hear properly",
                    PersonalityTrait = Constants.PersonalityTrait.Extrovert,
                    Weightage = 5,
                    QuestionId = q4.QuestionId,
                });
                await context.QuestionOptions.AddAsync(new QuestionOptions
                {
                    Description = "Are right up the front, adding your own comments in a loud voice",
                    PersonalityTrait = Constants.PersonalityTrait.Extrovert,
                    Weightage = 12,
                    QuestionId = q4.QuestionId,
                });

                // Question 5

                Question q5 = new Question
                {
                    QuestionId = Guid.NewGuid(),
                    Description = "During dinner parties at your home, you have a hard time with people who:"
                };

                await context.Questions.AddAsync(q5);

                await context.QuestionOptions.AddAsync(new QuestionOptions
                {
                    Description = "Ask you to tell a story in front of everyone else ",
                    PersonalityTrait = Constants.PersonalityTrait.Introvert,
                    Weightage = 12,
                    QuestionId = q5.QuestionId,
                });
                await context.QuestionOptions.AddAsync(new QuestionOptions
                {
                    Description = "Talk privately between themselves ",
                    PersonalityTrait = Constants.PersonalityTrait.Introvert,
                    Weightage = 9,
                    QuestionId = q5.QuestionId,
                });
                await context.QuestionOptions.AddAsync(new QuestionOptions
                {
                    Description = "Hang around you all evening ",
                    PersonalityTrait = Constants.PersonalityTrait.Extrovert,
                    Weightage = 7,
                    QuestionId = q5.QuestionId,
                });
                await context.QuestionOptions.AddAsync(new QuestionOptions
                {
                    Description = "Always drag the conversation back to themselves",
                    PersonalityTrait = Constants.PersonalityTrait.Extrovert,
                    Weightage = 10,
                    QuestionId = q5.QuestionId,
                });



                await context.SaveChangesAsync();
            }
        }
    }
}
