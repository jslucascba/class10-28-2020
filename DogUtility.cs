namespace class10_26_2020
{
    public class DogUtility
    {
        private Dog[] myDogs;

        public DogUtility(Dog[] myDogs) {
            this.myDogs = myDogs;
        }
        public void SetMyDogs(Dog[] myDogs) {
            this.myDogs = myDogs;
        }

        public Dog[] GetMyDogs() {
            return myDogs;
        }

        public int SequentialSearch(string searchVal) {
            int foundIndex = -1;
            for(int i=0; i < Dog.GetCount(); i++) {
                if(myDogs[i].Equals(searchVal)) {
                    foundIndex = i;
                }
            }
            return foundIndex;
        }

        public void SortArray(){
            for(int i = 0; i < Dog.GetCount()-1; i++){
                int minIndex = i;
                for(int j=i+1; j< Dog.GetCount(); j++){
                    if(myDogs[minIndex].CompareTo(myDogs[j]) > 0){
                        minIndex = j;
                    }
                }
                if(minIndex != i){
                    Swap(i, minIndex);
                }
            }
        }

        public void Swap(int x, int y){
            Dog temp = myDogs[x];
            myDogs[x] = myDogs[y];
            myDogs[y] = temp;
        }
    }
}