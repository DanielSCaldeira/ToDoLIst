﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ToDoList.Repository
{
    //IDesignTimeDbContextFactory -> utilizada para fazer as magreation
    // Classe criada para pegar a string de conexao no projeto API
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var fileName = Directory.GetCurrentDirectory() + $"/../ToDoList.API/appsettings.{environmentName}.json";

            var configuration = new ConfigurationBuilder()
                .AddJsonFile(fileName).Build();
            var connectionString = configuration.GetConnectionString("App");


            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseNpgsql(connectionString);

            return new ApplicationDbContext(builder.Options);
        }
    }
}
