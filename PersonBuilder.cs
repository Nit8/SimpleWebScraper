using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
    class PersonBuilder
    {
        private string _firstname;
        private string _lastname;
        private int _age;
        private int _eyecolor;
        private int _haircolor;

        public PersonBuilder() => SetDefaults();
        private void SetDefaults()
        {
            _firstname = "Admin";
            _lastname = "User";
            _age = 0;
            _eyecolor = 153;
            _haircolor = 153;
        }

        public PersonBuilder WithFirstName(string firstname)
        {
            _firstname=firstname;
            return this;
        }
        public PersonBuilder WithLastName(string lastname)
        {
            _lastname = lastname;
            return this;
        }
        public PersonBuilder WithAge(int age)
        {
            _age = age;
            return this;
        }
        public PersonBuilder WithHairColor(int haircolor)
        {
            _haircolor = haircolor;
            return this;
        }
        public PersonBuilder WithEyeColor(int eyecolor)
        {
            _eyecolor = eyecolor;
            return this;
        }

        public Person Build()
        {
            Person person=new Person(_firstname,_lastname,_age,_eyecolor,_haircolor);
            return person;
        }
    }
}
