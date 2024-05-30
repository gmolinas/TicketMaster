﻿using Application.Common.Interfaces;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

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
            services.AddTransient<IDataRepository>(provider =>
            {
                return RepositoryFactory.CreateRepository();
            });
        }

    }
}
