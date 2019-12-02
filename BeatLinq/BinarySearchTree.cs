using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BeatLinq
{
    class BinarySearchTree
    {
        public static void Run(string fileName, string guid)
        {
            List<Record> records = FileReader.ReadFile(fileName);
            Stopwatch stopwatch = Stopwatch.StartNew();
            Node headNode = BuildTree(records);
            long buildTicks = stopwatch.ElapsedTicks;
            Record record = FindByGuid(guid, headNode);
            long totalTicks = stopwatch.ElapsedTicks;
            Console.WriteLine($"BST took {buildTicks} to build, but found {record.Guid} {record.Name} in {(totalTicks - buildTicks)} ticks");
        }

        public static Node BuildTree(List<Record> records)
        {
            Node headNode = new Node(records.First());

            foreach (Record record in records.Skip(1))
            {
                TraverseTreeAndAddLeaf(record, headNode);
            }

            return headNode;
        }

        public static void TraverseTreeAndAddLeaf(Record record, Node node)
        {
            if (String.Compare(record.Guid, node.record.Guid) < 0)
            {
                if (node.left == null)
                {
                    node.left = new Node(record);
                }
                else
                {
                    TraverseTreeAndAddLeaf(record, node.left);
                }
            }
            else
            {
                if (node.right == null)
                {
                    node.right = new Node(record);
                }
                else
                {
                    TraverseTreeAndAddLeaf(record, node.right);
                }
            }
        }

        public static Record FindByGuid(string guid, Node node)
        {
            int comparison = String.Compare(guid, node.record.Guid);

            if (comparison == 0)
            {
                return node.record;
            }
            else if (comparison < 0)
            {
                return FindByGuid(guid, node.left);
            }
            else
            {
                return FindByGuid(guid, node.right);
            }
        }
    }

    class Node
    {
        public Record record;
        public Node left;
        public Node right;

        public Node(Record record)
        {
            this.record = record;
        }
    }
}
