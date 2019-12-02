using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Dreidel
{
    public class Dreidel
    {
        private readonly Random _random = new Random();

        public DreidelValue CurrentValue { get; private set; }

        public async Task SpinAsync()
        {
            var newValue = _random.Next(1, 5);
            CurrentValue = await DreidelValue.GetByIdAsync(newValue);
        }
    }
}
