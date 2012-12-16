using System;

namespace LoggerPoc.Service
{
    public class ServiceTwo : IServiceTwo
    {
        public void Baz()
        {
            Console.WriteLine("In ServiceTwo.Baz");
        }
    }
}