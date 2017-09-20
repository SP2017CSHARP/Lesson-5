using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using End.Models;

namespace End
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Statics

            //Overloads
            //Statics.Divide();

            //static assignment
            //Statics.StringTrimmer();

            #endregion

            //Assignment 1: 

            //Add an animal of your choosing, override the speak and two string methods to make 
            //it make the right sound. Use the base constructor as your constructor 

            //Assignment two: 
            //Make a new class called "PetStore"
            //It should have a list of type Animal called "Animals"

            //in its constructor, it should initiate with one type of each animal added to its list

            //it should have two methods: 

            //1: A method that makes each animal in the animal list make its individual noise (speak method)

            //2; A method that returns which type of animal each animal in the list is. 

            //make a new instance of petstore in program.cs using your constructor and run both the methods

            //PetStore p = new PetStore();

            //Console.WriteLine(p.StoreNoise());

            //Console.WriteLine(p.GetAllTypesOfAnimals());


            //mini assignment


           //Create a base class: Aircraft

            //Create two other classes that inherit from Aircraft: Airplane; Helicoptor; 

            //Aircraft should have a list of type aircraft that you can add planes and helicoptors to 

            //They should all be able to make a sound when they take off EngineSound();

            //They should all have a .ToString() override that lists information about the plane or helicoptor 

            //Aircraft Fields/Props: Name, SpeedInKM, Year Produced 

            //Aircraft other: List of aircrafts, ToStringOverride that writes the fields out, virtual method for EngineSound()

            //Airplane Props field: NumberOfWings, 
            //Constructor to initialize ALL FIELDS (even the inherited ones)
            //unique EngineSound(); ToString that inherits the base class to string and adds Airplane specific fields

            //Helicoptor: 
            





        }
    }
}
