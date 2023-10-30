using QuestionExcersise.Interfaces.Models;
using QuestionExcersise.Interfaces.ViewModelServices;
using QuestionExcersise.ViewModels;

namespace QuestionExcersise.ViewModelServices
{
    public class QuestionViewModelService : IQuestionViewModelService
    {
        public List<QuestionViewModel> GetQuestionViewModels(List<IQuestion> questions)
        {
            //Write code to return a QuestionViewModel per IQuestion with the response/s in the correct format
            //Format for SingleQuestion is just the response as is
            //For MultiQuestion we want a comma seperated list
            //Think about how this can be exteded in the future if we have other question types 
            throw new NotImplementedException();
        }
    }
}
