using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fibonacci
{
    public static class Compute
    {
        public static int Fib(int i)
        {
            if (i <= 2) return 1;
            return Fib(i - 2) + Fib(i - 1);
        }

        public static IList<int> Execute(string[] args)
        {
            var results = new ConcurrentBag<int>();
            Parallel.ForEach(args, arg =>
            {
                var result = Fib(int.Parse(arg));
                results.Add(result);
            });
            return results.ToList();
        }
    }
}