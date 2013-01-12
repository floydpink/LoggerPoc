using System;
using System.Threading.Tasks;

namespace LoggerPoc.Service
{
    public class ServiceTwo : IServiceTwo
    {
        public Task Baz()
        {
            Console.WriteLine("In ServiceTwo.Baz");
            return Task.Delay(2000);
        }
    }
}