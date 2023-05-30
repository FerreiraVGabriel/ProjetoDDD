using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
         public static void ConfigureDependenciesRepository (IServiceCollection serviceCollection) {
            serviceCollection.AddScoped (typeof (IRepository<>), typeof (BaseRepository<>));

            serviceCollection.AddDbContext<MyContext> (
                options => options.UseMySql ("Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=mudar@123")
            );
        }
    }
}