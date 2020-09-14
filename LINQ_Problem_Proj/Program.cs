using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problem_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            var results = words.Where(w => w.Contains("th"));
            foreach (var word in results)
            {
                Console.WriteLine(results);
            }

            List<string> names = new List<string>() { "mike", "brad", "nevin", "zack", "mike" };

            return names.Distinct().ToList();

            public static double AverageGrades(List<string> gradeStrings)
            {
                return gradeStrings
                    .Select(s => s.Split(',')
                        .Select(g => Double.Parse(g))
                            .OrderBy(a => a).Skip(1).Average())
                    .Average();
            }

        }
    }
}
