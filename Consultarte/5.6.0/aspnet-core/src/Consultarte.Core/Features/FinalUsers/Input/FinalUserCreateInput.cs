using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultarte.Features.FinalUsers.Input
{
    [AutoMap(typeof(FinalUser))]
    public class FinalUserCreateInput
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Department { get; set; }
        public string Municipality { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string CellphoneNumber { get; set; }
        public bool IsActive { get; set; }
    }
}
