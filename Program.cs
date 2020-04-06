using System;

namespace Assignment4
{
    class Program
    {

        static Dog dog1 =  new Dog("spike", "lab", 5);
        static Dog dog2 =  new Dog("bloo", "poodle", 3);
        static Dog dog3 =  new Dog("poppers", "German Sheppard", 8);

        static Dog[] dogs = new Dog[] {dog1,dog2,dog3};
        static Iterator iter = new Iterator(dogs);
        static void Main(string[] args)
        {
            start();
        }

        public static void start(){
            
            Console.WriteLine("This is dog in a bag 9000.\n" +
                                "Here you will be able to select the dog of your dreams...Blind.\n" +
                                "Good luck(you can cheat too)!"

            
            
            );

            int answer = 0;

            do{


                Console.WriteLine("1. List dogs.");
                Console.WriteLine("2. Pick a Dog Blind.");
                Console.WriteLine("3. Quit.");

                int.TryParse(Console.ReadLine(),out answer);
                
                if (answer < 1 || answer > 3){
                    Console.WriteLine("Please enter a valid number");
                }
                switch (answer)
                {
                    case 1:
                        listDogs();
                        break;
                    case 2:
                        pickADog();
                        break;
                    default:
                        break;
                }
            }while(answer != 3);

            
            
            
        }

        public static void pickADog(){
            int i=0;
            String answer = "";
            while(i < dogs.Length && answer != "y"){
                
                Console.WriteLine("Would you like to pick this dog?(y/n)");
                answer = Console.ReadLine().ToLower();
                if(answer != "y" && answer != "n"){
                    do{
                        Console.WriteLine("Please enter y or n.");
                        answer = Console.ReadLine().ToLower();
                    }while(answer != "y" && answer != "n");
                }
                iter.next();
                i++;
            }
            if(answer != "y"){
                Console.WriteLine("You ran out of dogs!");
            } else {
                Console.WriteLine("You picked " + iter.getElement().ToString());
            }
            iter.reset();
            
        }
        public static void listDogs(){
            for(int i = 0;i < dogs.Length; i++){
                Console.WriteLine(iter.getElement().ToString());
                iter.next();
            }
            iter.reset();
        }
    }
}
