using GameName.Demo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameName.Demo.Entity
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string NationalityId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}