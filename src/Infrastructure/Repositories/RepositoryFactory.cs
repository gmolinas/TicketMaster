using Application.Common.Interfaces;
using System;
using System.Configuration;

namespace Infrastructure.Repositories
{
    public class RepositoryFactory
    {
        public static IDataRepository CreateRepository()
        {
            string repositoryType = ConfigurationManager.AppSettings["RepositoryType"];
            string connectionString = ConfigurationManager.ConnectionStrings["TicketMasterDb"].ConnectionString;

            switch (repositoryType)
            {
                case "SQL":
                    return new SqlDataRepository(connectionString);
                case "MEMORY":
                    return new MemoryDataRepository();
                default:
                    throw new InvalidOperationException("Tipo de repositorio no soportado.");
            }
        }
    }
}
