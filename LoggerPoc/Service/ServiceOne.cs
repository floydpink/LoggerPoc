using System;

namespace LoggerPoc.Service
{
    public class ServiceOne : IServiceOne
    {
        public void Foo()
        {
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