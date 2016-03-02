using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    class Program {
        static void Main(string[] args) {
            Function firstFunction = new Function();

            // Pet
            Pet petNumber1 = new Pet();
            petNumber1.Name = "Zealot";
            petNumber1.Colour = "black";

            // Employee
            Employee employeeNumber1 = new Employee();
            employeeNumber1.Ethnicity = "Kaukasian";
            employeeNumber1.Prename = "Magnus";
            employeeNumber1.Surname = "Svensson";
            employeeNumber1.Pet = petNumber1;
            
            Console.WriteLine(employeeNumber1.tellEthnicity());
            Console.WriteLine(employeeNumber1.Signature());
            Console.WriteLine(employeeNumber1.Pet.callPet());

            Console.WriteLine();

            // Person 1
            Person personNumber1 = new Person();
            personNumber1.Prename = "Sergej";
            personNumber1.Surname = "Markov";
            personNumber1.Sex = "Male";

            // Person 2
            Person personNumber2 = new Person();
            personNumber2.Prename = "Anna";
            personNumber2.Surname = "Kournikova";
            personNumber2.Sex = "Female";

            // Association
            personNumber1.Slave = personNumber2;
            personNumber1.Pet = petNumber1;

            Console.WriteLine(personNumber1.Signature());
            Console.WriteLine(personNumber1.Pet.callPet());
            Console.WriteLine(personNumber1.Slave.Signature());
            
            Console.ReadKey();
        }
    }
}
