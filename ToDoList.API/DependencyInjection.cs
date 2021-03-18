using Microsoft.Extensions.DependencyInjection;
using ToDoList.Interface;
using ToDoList.Repository;

namespace ToDoList.API
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection serviceProvider)
        {
            RepositoryDependence(serviceProvider);
        }

        private static void RepositoryDependence(IServiceCollection serviceProvider)
        {
            serviceProvider.AddScoped<IListaRepository, ListaRepository>();
        }
    }
}
