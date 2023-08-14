using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace SimpleProg
{
    internal class LINQDemo
    {
        public void ShowResults()
        {

            int[] scores = { 90, 71, 82, 93, 75, 82 };
            int highScoreCount = (
            from score in scores
            where score > 80
            select score).Count();
            Console.WriteLine(highScoreCount);

            Console.WriteLine();
            IEnumerable<int> scoreQuery = (
            from score in scores
            where score > 80
            orderby score descending
            select score);

            foreach (int testScore in scoreQuery)
            {
                Console.WriteLine(testScore);
            }
            Console.WriteLine();

            int highScoresQuery = scores.First(Score => Score < 75);

            Console.WriteLine(highScoresQuery);
        }
      
        }

}







/*
 IEnumerable<int> highScoresQuery =
from score in scores
where score > 80
select score;
int scoreCount = highScoresQuery.Count();
Console.WriteLine(scoreCount);
*/