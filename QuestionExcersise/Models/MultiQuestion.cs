using QuestionExcersise.Interfaces.Models;

namespace QuestionExcersise.Models
{
    public class MultiQuestion : IQuestion
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public List<Response> Responses { get; set; }
    }
}
