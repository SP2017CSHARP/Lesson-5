using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Start.Models;
namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic static method Call
            //Statics.Multiply(5, 5);

            //Console.WriteLine(Statics.Divide(20, 4));

            //Statics.Divide();

            //Statics.StringTrimmer();

            //In class assignment: 

            //Create two more animals of your choice 
            //Create a constructor that inherits the parameters of the base constructor
            //override the Speak() and ToString() methods


            //PART TWO: 
            //Create a new Class called PetStore
            //Pet store should have one prop that is a LIST of type ANIMAL

            //PetStore should have a default constructor (no parameters). Inside the constructor, create a new instance of your 
            //animals list. Add one of each of your animals with a name

            //PetStore should have 2 Methods: 
            //1 StoreNoise()  :  StoreNoise will return a string. It will take each animal in your animal list, and print 
            // {AnimalName} says : and then that animals noise. each name and noise should be on a separate line

            //2 GetAllAnimalTypes() : GetAllAnimalTypes will return a string. For each animal in your animal list it will print there name,
            //and say what "type" it is. Each on a new line. 

            //GetAllAnimalTypes Hint: To get the animal type use the GetType() method (it is part of the object class) 
            //GetType() example foreach(Person p in People) 
            //{ 
            // p.GetType()
            //}

            PetStore p = new PetStore();

            Console.WriteLine(p.StoreNoise());
            Console.WriteLine(p.GetAllAnimalTypes());



        }
    }
}
