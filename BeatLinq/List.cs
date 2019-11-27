using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Linq;

namespace BeatLinq
{
    class List
    {
        public static void Run()
        {
            List<Person> people = FileReader.ReadFile();
            FindById(people, 789);
        }

        public static void FindById(List<Person> people, int id)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            people.First(p => p.Id == id);
            Console.WriteLine($"Person found in {stopwatch.ElapsedTicks} ticks");
        }
    }
}
