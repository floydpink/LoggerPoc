using System.Threading.Tasks;

namespace LoggerPoc.Service
{
    public interface IServiceOne
    {
        void Foo();
        Task<int> Bar(int left, int right);
        int Boom(int num);
    }
}