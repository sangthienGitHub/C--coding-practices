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

        string _twitterAddress;
        string TwitterAddress
        {
            //make sure the twitter address start with @
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }else
                {
                    throw new Exception("The twitter address must begin with @");
                }
            }
        }

        Elementary.Volume volume;
        HighSchool.Volume volume2;
    }
}
