using System;
using System.Collections.Generic;
using Autofac;
using Autofac.Configuration;
using caculator;
using caculator.Item;

namespace app
{
    class Program
    {
        static void Main()
        {
            var items = new List<IPostable>
                            {
                                new Book(2), new Food(4)
                            };
            var builder = new ContainerBuilder(); 
            builder.RegisterType<PostageCalculator>();
            builder.RegisterModule(new ConfigurationSettingsReader("autofac"));

            using (var container = builder.Build())
            {
                var calculator = container.Resolve<PostageCalculator>();
                Console.WriteLine(calculator.GetPostage(items));
                Console.ReadKey();
            } 
        }
    }
}
