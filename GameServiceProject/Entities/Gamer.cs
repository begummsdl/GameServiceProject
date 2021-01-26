using GameServiceProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameServiceProject.Entities
{
    public class Gamer 
    {
        public int Id { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
