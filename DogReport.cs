
using System;

namespace class10_26_2020
{
    public class DogReport
    {
        private Dog[] myDogs;

        public DogReport(Dog[] myDogs) {
            this.myDogs = myDogs;
        }
        public void SetMyDogs(Dog[] myDogs) {
            this.myDogs = myDogs;
        }

        public Dog[] GetMyDogs() {
            return myDogs;
        }

        public void PrintAllDogs() {
            for(int i=0; i < Dog.GetCount(); i++) {
                Console.WriteLine(myDogs[i].ToString());
            }
        }

    }
}