using System;
using System.Collections.Generic;

namespace Testing.Models
{
    public partial class Users
    {
        public int AutoNum { get; set; }
        public string UserId { get; set; }
        public byte[] PasswordHash { get; set; }
        public string UserToken { get; set; }
    }
}
