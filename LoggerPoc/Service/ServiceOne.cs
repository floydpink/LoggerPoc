using System;
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

        public int Bar(int left, int right)
        {
            Console.WriteLine("In ServiceOne.Bar");
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