using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            start();
        }

        public static void start(){
            Dog dog1 =  new Dog("spike", "lab", 5);
            Dog dog2 =  new Dog("bloo", "poodle", 3);
            Dog dog3 =  new Dog("poppers", "German Sheppard", 8);

            Dog[] dogs = new Dog[] {dog1,dog2,dog3};
            Iterator iter = new Iterator(dogs);
            
            for(int i = 0;i < dogs.Length; i++){
                Console.WriteLine(iter.getElement().ToString());
                iter.next();
            }
            
        }
    }
}
