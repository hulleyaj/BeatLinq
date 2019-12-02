using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace BeatLinq
{
    class FileReader
    {
        public static List<Record> ReadFile(string fileName)
        {
            string json = File.ReadAllText(fileName);

            return JsonSerializer.Deserialize<List<Record>>(json);
        }
    }
}
