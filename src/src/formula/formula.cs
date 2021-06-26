using System;
using System.IO;
using System.Text.RegularExpressions;

namespace formula
{
    public class SeriesOrganizer
    {
        private const string pattern = @"^(?=.*[SERIES_NAME])(?=.*S(?<season>\d{1,2})E(?<episode>\d{1,2}))";
        public SeriesOrganizer(string seriesName, string directory)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Series Organizer");
            Console.WriteLine("Searching for files that match the provided name and the pattern S(XX)E(XX)");
            var files = Directory.GetFiles(directory);
            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                var match = Regex.Match(fileInfo.Name, pattern.Replace("[SERIES_NAME]", seriesName));
                if (match.Success)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"MATCH: {fileInfo.Name}.");
                    var season = GetGroupValueAndFormat("season", match);
                    var episode = GetGroupValueAndFormat("episode", match);
                    var newFileName = $"{seriesName} - S{season}E{episode}{fileInfo.Extension}";
                    var seasonDirectory = $@"{directory}\S{season}";
                    Directory.CreateDirectory(seasonDirectory);
                    File.Move(fileInfo.FullName, $@"{seasonDirectory}\{newFileName}");
                    Console.WriteLine($"SAVED: {newFileName}.");
                }
                else
                {
                    var notMachDirectory = $"{directory}/NotMatchFiles";
                    Directory.CreateDirectory(notMachDirectory);
                    File.Move(fileInfo.FullName, $@"{notMachDirectory}\{fileInfo.Name}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"NOT MATCH: {fileInfo.Name}.");
                }
            }

            Console.ResetColor();
        }

        private static string GetGroupValueAndFormat(string group, Match match)
        {
            return int.Parse(match.Groups[group].Value).ToString().PadLeft(2, '0');
        }
    }
}
