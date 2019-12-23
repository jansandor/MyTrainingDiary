using System;
using System.Collections.Generic;
using System.Text;
using MyTrainingDiary.DAL.Entities;
using MyTrainingDiary.DAL.Interfaces;

namespace MyTrainingDiary.DAL.Models
{
    public class UserCredentialsModel : IUserCredentials
    {
        public Guid Id { get; set; }
        public string Username { get; }
        public string Password { get; }

        public UserCredentialsModel(IUserCredentials userCredentials)
        {
            Id = userCredentials.Id;
            Username = userCredentials.Username;
            Password = userCredentials.Password;
        }

        public UserCredentialsModel(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
