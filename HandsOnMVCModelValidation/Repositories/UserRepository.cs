using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCModelValidation.Models;
namespace HandsOnMVCModelValidation.Repositories
{
    public class UserRepository
    {
        public static List<User> list = new List<User>()
        {
            new User(){ Name="Siddu",Uname="12Siddu",Pawd="123" }
        };
        public UserRepository()
        {
            //list = new List<User>();
            //list.Add(new User()
            //{
            //    Name = "Karthik",
            //    Uname = "karthik143",
            //    Pawd = "1234"
            //}) ;
        }
        public void Add(User item)
        {
            list.Add(item);//add user data intlo list
        }
        public User Validate(string name,string pwd)
        {//validating the vdata
            foreach(var item in list)
            {
                if (item.Uname == name && item.Pawd == pwd)
                {
                    return item;
                }
            }return null;
        }

    }
}
