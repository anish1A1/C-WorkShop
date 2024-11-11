 // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.Write("Enter Your London Met Id: ");

// string studentId = Console.ReadLine();



// Console.Write("Enter Your Name: ");
// string name = Console.ReadLine();

// Console.Write("Enter your Age: ");
// string age = Console.ReadLine();

// Console.Write("Gender: ");

// string gender = Console.ReadLine();

// Console.WriteLine($"Your Name is {name} and your age is {age} and your gender is {gender} and londonmet Id is {studentId}");


using System;
class Program{
    static void Main(string[] args){
        string [] names = {"Arjun", "james", "Prazwal", "Bimash"};

        Console.WriteLine("Names of Noobs: ");
        
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"NOOB's are {i} --> {names[i]}");
        }
    }
}
