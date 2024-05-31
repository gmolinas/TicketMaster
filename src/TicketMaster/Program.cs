using Application.Common.Interfaces;
using Infrastructure.Extensions;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;
using TicketMaster.Controllers;

namespace TicketMaster
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var FormPrincipal = serviceProvider.GetRequiredService<FormPrincipal>();

                System.Windows.Forms.Application.Run(FormPrincipal);
            }

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<FormPrincipal>();
            services.AddSingleton<IDataRepository>(provider =>
            {
                return RepositoryFactory.CreateRepository();
            });

            // Registrar automáticamente todos los casos de uso
            var assembly = Assembly.GetAssembly(typeof(IUseCase)); // Cambia IUseCase por una interfaz común en tu proyecto
            services.AddAllImplementationsOfInterface(typeof(IUseCase), assembly);

            services.AddTransient<TicketMasterController>();
        }

    }
}
