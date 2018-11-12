using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class Name : IName
    {
        public string GivenName { get; set; }
        public string LastName { get; set; }

        public override string ToString() => $"{GivenName} {LastName}";
    }
}
