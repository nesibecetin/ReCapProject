using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Account :IEntity
    {
        public int AccountId { get; set; }
        public int CustomerId { get; set; }
        public int Balance { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public int Cvv { get; set; }
        public long AccountNumber { get; set; }
    }
}
