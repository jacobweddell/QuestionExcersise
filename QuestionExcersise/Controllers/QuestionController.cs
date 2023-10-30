using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestionExcersise.Interfaces.Models;
using QuestionExcersise.Interfaces.ViewModelServices;
using QuestionExcersise.Models;
using QuestionExcersise.ViewModels;

namespace QuestionExcersise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionViewModelService _questionViewModelService;
        public QuestionController(IQuestionViewModelService questionViewModelService)
        {
            _questionViewModelService = questionViewModelService;
        }

        [HttpGet]
        public List<QuestionViewModel> GetQuestions()
        {
            return _questionViewModelService.GetQuestionViewModels(QuestionData);
        }

        private static List<IQuestion> QuestionData = new()
        {
            new SingleQuestion
            {
                Number = 1,
                Name = "Who won the Grammy for Best Metal Performance in 1992?",
                Response = new Response { Text = "Metallica" }
            },
            new SingleQuestion
            {
                Number = 2,
                Name = "Who headlined the main stage at Glastonbury in 2014?",
                Response = new Response { Text = "Metallica" }
            },
            new MultiQuestion
            {
                Number = 3,
                Name = "Name 3 Metallica albums:",
                Responses = new List<Response>
                {
                    new Response{ Text = "Ride the Lightning" },
                    new Response{ Text = "Master of Puppets" },
                    new Response{ Text = "...And Justice For All" }
                }
            },
            new MultiQuestion
            {
                Number = 4,
                Name = "Name the members of Metallica:",
                Responses = new List<Response>
                {
                    new Response{ Text = "James Hetfield" },
                    new Response{ Text = "Kirk Hammett" },
                    new Response{ Text = "Lars Ulrich" },
                    new Response{ Text = "Robert Trujillo" },
                }
            }
        };
    }
}
