using System.Collections.Generic;
using static WinFormsApp1.Form1;

namespace WinFormsApp1
{
    public class Class1
    {
        public List<Person> People { get; set; }


        public Class1()
        {
            People = new List<Person>
            {
                new Person { ID = 1, Name = "John" },
                new Person { ID = 2, Name = "Jane" },
                new Person { ID = 3, Name = "Doe" }
            };
        }
    }
}
