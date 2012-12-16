using LoggerPoc.Bootstrap;
using LoggerPoc.Service;
using System;

namespace LoggerPoc
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bootstrapper.BootstrapStructureMap();

                IServiceOne serviceOne = Bootstrapper.GetInstance<IServiceOne>();
                IServiceTwo serviceTwo = Bootstrapper.GetInstance<IServiceTwo>();

                serviceOne.Foo();
                serviceOne.Bar(34, 56);
                serviceOne.Boom(3);

                serviceTwo.Baz();

                serviceOne.Boom(0);

                Console.WriteLine("Done...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.ReadKey(true);
            }
        }
    }
}
