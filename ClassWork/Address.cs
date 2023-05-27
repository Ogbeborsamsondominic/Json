using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
    public class Address
    {
        public Guid Id { get; set; } = new Guid();
        public string MainAddress { get; set; }
        public string LGA { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public Guid StudentId { get; set; }

    }
}
