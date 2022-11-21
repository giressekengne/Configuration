using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace Configuration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            Settings settings = config.GetRequiredSection("settings").Get<Settings>();
            Console.WriteLine(settings.GIGI);
            Console.WriteLine(settings.MATHI);
            
        }
      
        public class Settings
        {
            public string MATHI { get; set; }
            public string GIGI { get; set; }
        }
    }
}
