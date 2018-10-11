using System;
using System.Collections.Generic;
using System.Text;
using Repository;
using Repository.Model;
namespace Service
{
    public class UserService : IUserService
    {
        private IRepository<Userinfo> userRepository;
        public UserService(IRepository<Userinfo> repo)
        {
            userRepository = repo;
        }
        public string Login(string username, string password)
        {
            return "in login";
        }

        public string Register(string username, string password)
        {
            return "in Register";
        }
    }
}
