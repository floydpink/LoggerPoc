using System;
using System.Threading.Tasks;
using log4net;

namespace LoggerPoc.Service
{
    public class ServiceOne : IServiceOne
    {
        private ILog _log;

        public ServiceOne(ILog log)
        {
            _log = log;
        }

        public ILog Log
        {
            get { return _log; }
        }

        public void Foo()
        {
            Log.Info("Example of organic logging from the business object. Staring application.");
            Console.WriteLine("In ServiceOne.Foo");
        }

        public async Task<int> Bar(int left, int right)
        {
            Console.WriteLine("In ServiceOne.Bar. About to add a delay of a second");
            await Task.Delay(1000);
            Console.WriteLine("Done with the delay. Doing the math now");
            var sum = left + right;
            return sum;
        }

        public int Boom(int num)
        {
            Console.WriteLine("In ServiceOne.Boom");
            return 12 / num;
        }
    }
}