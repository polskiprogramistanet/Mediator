using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;

namespace MediaT_R
{
    class Program
    {
        static void Main(string[] args)
        {
            // This class will contains your injections
            var services = new ServiceCollection();

            // Configures your injections
            ConfigureServices(services);

            ////implementation
            using (ServiceProvider sp = services.BuildServiceProvider())
            {
                var exec = sp.GetRequiredService<Implementator>();
                exec.Execute();
            }


        }

        // This method will be responsible to register your injections
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped<Implementator>();
        }

    }
    public class Implementator
    {
        IMediator mediator;
        public Implementator(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async void Execute()
        {
            var outputmessage = await this.mediator.Send(new ClassABC { Text = "Dupa jasiu" });
            Console.WriteLine(outputmessage);
        }

    }
    

}
