using System;
namespace MyClass{
    public class Person{
        public string name;
        public int age;
        public bool male;
        public Person(){
            name = "ABC";
            age=20;
            male=true;
        }
    }
    class Pearson{
        public string Name
        {get;set;}
    }
    public class Professional{
        public string profession;
        public Professional(string Profession){
            profession = Profession;
        }
    }
    class Vehicle{
        public string brand = "Ford";
        public void honk(){
            Console.WriteLine("Tuut,tuut!");
        }
    }
    class Car:Vehicle{
        public string modelName = "Mustang";
    }
    class Animal{
        public virtual void animalSound(){
            Console.WriteLine("The animal makes a sound");
        }
    }
    class Pig:Animal{
        public override void animalSound()
        {
            Console.WriteLine("Pig says: wee wee");
        }
    }
    class Dog:Animal{
        public override void animalSound()
        {
            Console.WriteLine("Dog says: bow wow");
        }
    }
    abstract class Bird{
        public abstract void birdSound();
        public void sleep(){
            Console.WriteLine("zzz");
        }
    }
    class Pigeon:Bird{
        public override void birdSound()
        {
            Console.WriteLine("pigeon says: coo coo");
        }
    }
    interface Ianimal{
        void animalSound();
    }
    interface Human{
        void greet();
    }
    class IPig:Ianimal{
        public void animalSound(){
            Console.WriteLine("pig says: boo woo");
        }
    }
    class IHuman:Ianimal,Human{
        public void greet(){
            Console.WriteLine("Greeting from human!");
        }
        public void animalSound(){
            Console.WriteLine("haa haa haa");
        }
    }
    enum Level{
        Low=-10,
        Medium,
        High,
    }
    class Program{
        static void Main(string[] args){
            // Person Jenish = new Person();
            // Console.WriteLine(Jenish.age);
            // Jenish.age = 22;
            // Console.WriteLine(Jenish.age);
            // Professional jenish = new Professional("IIOT engineer");
            // Console.WriteLine(jenish.profession);
            // Pearson james = new Pearson();
            // james.Name = "James";
            // Console.WriteLine(james.Name);
            // Car myCar = new Car();
            // myCar.honk();
            // Console.WriteLine(myCar.brand+" "+myCar.modelName);
            // myCar.brand = "Audi";
            // myCar.modelName = "A4";
            // Console.WriteLine(myCar.brand+" "+myCar.modelName);
            // Animal myAnimal = new Animal();
            // Animal myPig  =new Pig();
            // Animal myDog = new Dog();
            // myAnimal.animalSound();
            // myPig.animalSound();
            // myDog.animalSound();
            // Pigeon myPigeon = new Pigeon();
            // myPigeon.birdSound();
            // myPigeon.sleep();
            // IPig myIPig = new IPig();
            // myIPig.animalSound();
            // IHuman myIHuman = new IHuman();
            // myIHuman.animalSound();
            // myIHuman.greet();
            Level myVar = Level.High;
            Console.WriteLine(myVar);
            int myVal = (int) Level.Medium;
            Console.WriteLine(myVal);
            int myNum = (int) Level.Low;
            Console.WriteLine(myNum);
        }
    }    
}