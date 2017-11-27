using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    using Collage;
    using System;

    public interface IRandomGenerator
    {
        int Next(int min, int max);
    }

    internal class RandomGenerator : IRandomGenerator
    {
        private readonly Random random;

        public RandomGenerator()
        {
            this.random = new Random();
        }

        public int Next(int min, int max)
        {
            return this.random.Next(min, max);
        }
    }
}
