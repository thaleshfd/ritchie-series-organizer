using System;
using formula;

namespace main
{
    static class main
    {
        static void Main(string[] args)
        {
            string seriesName = Environment.GetEnvironmentVariable("RIT_INPUT_TEXT_1");
            string directory = Environment.GetEnvironmentVariable("RIT_INPUT_TEXT_2");

            new formula.SeriesOrganizer(seriesName, directory);
        }
    }
}
