using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Model.Employees
{
    public class Title
    {
        public String Prefix { get; set; }
        public String Suffix { get; set; }

        public Title(String prefix, String suffix)
        {
            this.Prefix = prefix;
            this.Suffix = suffix;
        }
    }
}
