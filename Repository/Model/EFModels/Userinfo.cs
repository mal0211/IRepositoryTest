using System;
using System.Collections.Generic;

namespace Repository.Model
{
    public partial class Userinfo
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
