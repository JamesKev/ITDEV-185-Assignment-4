using System;
namespace Assignment4
{
    class Dog
    {
        private string name;
        private string breed;
        private int age;
        public Dog(string name, string breed, int age){
            this.name  = name;
            this.breed = breed;
            this.age = age;
        }

        public string getName(){
            return this.name;
        }
        public void setName(string name){
            this.name = name;
        }
        public string geBreed(){
            return this.breed;
        }
        public void setBreed(string breed){
            this.breed = breed;
        }
        public int getAge(){
            return this.age;
        }
        public void setAge(int age){
            this.age = age;
        }
        
        public override string ToString(){
            return name;
        }
    }
    
}