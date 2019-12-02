using System;

namespace BeatLinq
{
    class Program
    {
        //100,000 record file guids incase your computer struggles to open it ->
        //a9941071-3ef7-474c-b40e-4adea9118621
        //77fd655f-fb96-45c5-8335-e588faba8292
        //e471fa6d-3124-47d0-b788-e1a76ff6a8d6
        //1e8e375d-2824-481d-8937-fa36346f369e
        //32528f9d-6283-4a3d-a1d6-6639841b44ad
        //fb3cd4c1-2d21-42f1-9361-199ce770d5b8
        //5642fe3b-d655-4f3b-83b8-ad3006373596

        static void Main(string[] args)
        {
            string fileName = @"..\..\..\data100000.json";
            string guid = "32528f9d-6283-4a3d-a1d6-6639841b44ad";

            List.Run(fileName, guid);
            BinarySearchTree.Run(fileName, guid);

            Console.ReadKey();
        }
    }
}
