using System;
using System.Threading.Tasks;
using LoggerPoc.Bootstrap;
using LoggerPoc.Service;

namespace LoggerPoc
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                DoStuff();
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

        private static async Task DoStuff()
        {
            Bootstrapper.BootstrapStructureMap();

            var serviceOne = Bootstrapper.GetInstance<IServiceOne>();
            var serviceTwo = Bootstrapper.GetInstance<IServiceTwo>();

            serviceOne.Foo();
            Console.WriteLine("Bar result: " + await serviceOne.Bar(34, 56));
            serviceOne.Boom(3);

            await serviceTwo.Baz();

            serviceOne.Boom(0);

            Console.WriteLine("Done...");
        }
    }
}