using System;
using System.Collections.Generic;
using System.Text;

namespace MyTrainingDiary.DAL.Interfaces
{
    public interface IUserCredentials
    {
        Guid Id { get; set; }
        string Username { get; }
        string Password { get; }
    }
}
