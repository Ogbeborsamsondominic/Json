using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a list of students
            List<Student> students = new List<Student>();

            // Create a student object
            Student student = new Student();
            student.FirstName = "Ogbebor";
            student.LastName = "Samson";
            student.OtherName = "Dominic";
            student.Email = "samson@gmail.com";
            student.PhoneNumbers.Add("018928338710383");
            student.PhoneNumbers.Add("8383833838747474");
            student.Addresses.Add(new Address()
            {
                MainAddress = "3 Ikeja",
                City = "Lagos",
                State = "Lagos",
                LGA = "Ikeja",
                Country = "London",
                StudentId = student.Id,
            });

            student.Addresses.Add(new Address()
            {
                MainAddress = "10 Shomolu",
                City = "Lagos",
                State = "Lagos",
                LGA = "Bariga",
                Country= "Canada",
                StudentId = student.Id
            });
            students.Add(student);
            students.Add(student);

            // Write the student data to a JSON file
            WriteToJson writeToJson = new WriteToJson();
            writeToJson.WriteToJsons(students);

            // Read the student data from the JSON file
            ReadFromJson readFromJson = new ReadFromJson();
            List<Student> result = readFromJson.ReadFromJsons("data.json");

            // Find the student to update by first name and last name
            Student currentUser = result.FirstOrDefault(x => x.FirstName == "Ogbebor" && x.LastName == "Samson");

            // Update the last name and first name
            currentUser.LastName = "Johnson";
            currentUser.FirstName = "Mark";

            // Add a new address for the student
            currentUser.Addresses.Add(new Address()
            {
                MainAddress = "15 Yaba",
                City = "Lagos",
                State = "Lagos",
                LGA = "Yaba",
                Country = "Nigeria",
                StudentId = currentUser.Id
            });

            // Write the updated student data to the JSON file
            writeToJson.WriteToJsons(result);
        }
    }
}
