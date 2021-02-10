using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompleteWebApi.Data.AutoMapper
{
    public class UserInfoReadDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        // we dont want to show Age
        //public int age { get; set; }
    }
}
