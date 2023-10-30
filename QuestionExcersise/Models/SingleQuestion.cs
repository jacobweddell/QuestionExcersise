using QuestionExcersise.Interfaces.Models;

namespace QuestionExcersise.Models
{
    public class SingleQuestion : IQuestion
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public Response Response { get; set; }
    }
}
