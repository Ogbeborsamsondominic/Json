using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
    public class Student
    {
        public Guid Id { get; set; }= Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<string> PhoneNumbers { get; set; } = new List<string>();




    }
}
