using System.Net.Mail;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {   
            DateOnly dateConverted = new DateOnly();
            string nameInput;
            string birthdayInput;
            Console.WriteLine("Hola bienvenido al calculador de años");
            Console.WriteLine("Escribe tu nombre");
            nameInput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameInput}");
            Console.WriteLine("Escribe tu fecha de nacimineto de formato dd/mm/yy: ");
            birthdayInput = Console.ReadLine();
            bool IsDateValid = DateOnly.TryParse(birthdayInput. out dateConverted);
            if(IsDateValid == false) Console.WriteLine($"la fecha es inválida {birthdayInput}");
            var person = new Person
            {
                Name = nameInput,
                Birthday = dateConverted,
                Age = DateTime.Now.Year- dateConverted.Year
            };


            Console.WriteLine($"Tu nombre {person.Name}");
            Console.WriteLine($"Tu fecha de nacimineto {person.Birthday}");
            Console.WriteLine($"Tu edad {person.Age}");

        }

    public class Person
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public DateOnly Birthday { get; set; }
        }
    }
}