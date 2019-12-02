using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BeatLinq
{
    class List
    {
        public static void Run(string fileName, string guid)
        {
            List<Record> records = FileReader.ReadFile(fileName);
            Stopwatch stopwatch = Stopwatch.StartNew();
            Record record = FindByGuid(records, guid);
            long totalTicks = stopwatch.ElapsedTicks;
            Console.WriteLine($"List found {record.Guid} {record.Name} in {totalTicks} ticks");
        }

        public static Record FindByGuid(List<Record> records, string guid)
        {
            return records.First(p => p.Guid == guid);
        }
    }
}
