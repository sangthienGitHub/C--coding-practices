using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    class School
    {
        //Auto Properties
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Number { get; set; }

        private string _twitterAddress;
        public string TwitterAddress
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
