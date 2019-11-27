using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace BeatLinq
{
    class FileReader
    {
        public static List<Person> ReadFile()
        {
            string json = File.ReadAllText(@"..\..\..\data.json");

            return JsonSerializer.Deserialize<List<Person>>(json);
        }
    }
}
