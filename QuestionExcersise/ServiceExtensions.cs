using Microsoft.Extensions.DependencyInjection;
using QuestionExcersise.Interfaces.ViewModelServices;
using QuestionExcersise.ViewModelServices;

namespace QuestionExcersise
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddViewModelServices(this IServiceCollection services)
        {
            services.AddScoped<IQuestionViewModelService, QuestionViewModelService>();

            return services;
        }
    }
}
