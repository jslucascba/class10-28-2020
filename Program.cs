using System;

namespace class10_26_2020
{
    class Program
    {

        //Challenge 1: create text file with dog data, read into array
        static void Main(string[] args)
        {
            DogFile dogFile = new DogFile("input.txt");
            Dog[] myDogs = dogFile.GetAllDogs();
            DogReport dogReport = new DogReport(myDogs);
            dogReport.PrintAllDogs();
            DogUtility dogUtility = new DogUtility(myDogs);
            //int searchIndex = dogUtility.SequentialSearch("Sophie");
            //Console.WriteLine(searchIndex);

            dogUtility.SortArray();
            dogReport.PrintAllDogs();
            
        }
       
    }
}
