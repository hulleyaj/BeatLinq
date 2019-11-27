using System;
using System.Collections.Generic;
using System.Text;

namespace BeatLinq
{
    class BinarySearchTree
    {
        public static void Run()
        {
            List<Person> people = FileReader.ReadFile();
            BuildTree(people);
        }
        
        public static void BuildTree(List<Person> people)
        {

        }
    }
}
