using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Dreidel
{
    public class DreidelValue
    {
        public int Id { get; set; }
        public char Char { get; set; }

        public string Name { get; set; }

        public static DreidelValue Nun = new DreidelValue() { Id = 1, Char = '\u05E0', Name = "Nun" };
        public static DreidelValue Gimmel = new DreidelValue() { Id = 2, Char = '\u05D2', Name = "Gimmel" };
        public static DreidelValue Hay = new DreidelValue() { Id = 3, Char = '\u05D4', Name = "Hay" };
        public static DreidelValue Shin = new DreidelValue() { Id = 4, Char = '\u05E9', Name = "Shin" };

        public async static Task<DreidelValue> GetByIdAsync(int id)
        {
            var possibleValues = new List<DreidelValue>() { Nun, Gimmel, Hay, Shin };
            var value = possibleValues
                .Where(x => x.Id == id)
                .FirstOrDefault();

            return await Task.FromResult(value);
        }

        public override string ToString()
        {
            return $"{Char} : ({Name})";
        }
    }
}
