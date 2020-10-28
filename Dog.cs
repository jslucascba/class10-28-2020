using System;

namespace class10_26_2020
{
    public class Dog
    {
        private string name;
        private string breed;
        private int weight;
        private static int count;


        public Dog() {

        }
        public Dog (string name, string breed, int weight) {
            this.name = name;
            this.breed = breed;
            this.weight = weight;
        }
        public void SetName(string name) {
            this.name = name;
        }

        public string GetName() {
            return name;
        }
         public void SetBreed(string breed) {
            this.breed = breed;
        }

        public string GetBreed() {
            return breed;
        }
         public void SetWeight(int weight) {
            this.weight = weight;
        }

        public int GetWeight() {
            return weight;
        }
         public static void SetCount(int value) {
            value = count;
        }

        public static int GetCount() {
            return count;
        }

        public static void IncCount() {
            count++;
        }

        public void Bark() {
            Console.WriteLine("Woof woof!");
        }

        public bool Equals(Dog tempDog) {
            return this.name == tempDog.GetName();
        }

        public bool Equals(string tempName) {
            return this.name == tempName;
        }

        public override string ToString() {
            return name + "\t" + breed + "\t" + weight;
        }

        public int CompareTo(Dog value){
            return this.breed.CompareTo(value.GetBreed());
        }
    }
}