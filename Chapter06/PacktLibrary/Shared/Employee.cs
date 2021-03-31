using System;
using System.Text;

namespace PacktLibrary.Shared
{
    public class Employee : Person
    {
        public string Company { get; set; }

        public override string ToString()
        {
            return new StringBuilder(base.ToString())            
                .Append($"\n{this.Company} Company")
                .ToString();
        }
    }
}
