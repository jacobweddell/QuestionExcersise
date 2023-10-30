using QuestionExcersise.Interfaces.Models;
using QuestionExcersise.ViewModels;

namespace QuestionExcersise.Interfaces.ViewModelServices
{
    public interface IQuestionViewModelService
    {
        public List<QuestionViewModel> GetQuestionViewModels(List<IQuestion> questions);
    }
}
