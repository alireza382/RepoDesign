using RepoDesign.Domain.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDesign.Domain.Models
{
    public  class Universitiy
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public EUniverstySpecialType SpecialyType { get; set; }

        public string Email { get; set; }

        public string Site { get; set; }


    }
}
