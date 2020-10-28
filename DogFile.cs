using System;
using System.IO;

namespace class10_26_2020
{
    public class DogFile
    {
        private string fileName;


        public DogFile(string fileName) {
            this.fileName = fileName;
        }
        public void SetFileName(string fileName) {
            this.fileName = fileName;
        }

        public string GetFileName() {
            return fileName;
        }

         public Dog[] GetAllDogs() {
            Dog[] myDogs = new Dog[100];
            Dog.SetCount(0);
            StreamReader inFile = new StreamReader(fileName);
            string input = inFile.ReadLine();
            while(input != null) {
                string[] temp = input.Split('#');            
                myDogs[Dog.GetCount()] = new Dog(temp[0], temp[1], int.Parse(temp[2]));
                Dog.IncCount();
                input = inFile.ReadLine();
            }

            inFile.Close();

            return myDogs;
        }
    }
}