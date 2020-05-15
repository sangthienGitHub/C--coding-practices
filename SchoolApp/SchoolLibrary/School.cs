using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    class School
    {
        //Auto Properties
        string Name { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Zip { get; set; }
        string Number { get; set; }

        Elementary.Volume volume;
        HighSchool.Volume volume2;
    }
}
