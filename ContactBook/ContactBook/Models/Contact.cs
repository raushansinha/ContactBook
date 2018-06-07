using System;
using System.Collections.Generic;
using System.Text;

namespace ContactBook.Models
{
    public class Contact
    {
        public string Name
        {
                get { return FName + " " + LName; }
                set { value = FName + " " + LName; }
        }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }
        public string DeptNo { get; set; }
        public string Department { get; set; }
    }
}
