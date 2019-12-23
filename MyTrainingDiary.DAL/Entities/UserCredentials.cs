using System;
using System.Collections.Generic;
using System.Text;
using MyTrainingDiary.DAL.Interfaces;

namespace MyTrainingDiary.DAL.Entities
{
    public class UserCredentials : EntityBase, IUserCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }

        // udaje patri jedinemu uzivateli
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
