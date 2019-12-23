using MyTrainingDiary.DAL.Entities;
using MyTrainingDiary.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTrainingDiary.DAL.Models
{
    public class UserModel : IUser
    {
        public Guid Id { get; set; }

        public UserModel(User user) // todo tvorba uzivatele z entity pomoci interface?
        {
            Id = user.Id;
        }
    }
}
