using System;
using System.Collections.Generic;
using System.Text;

namespace D8r
{
    class Profile
    {
        string name;
        int age;
        string city;
        string country;
        string pronouns;
        string[] hobbies;

        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = new string[0];
        }

        //method to describe profile
        public string ViewProfile()
        {
            string bio = $"Name = {name}\n Age = {age}\n City = {city}\n Country = {country}\n Pronouns = {pronouns}";

            bio += "\nHobbies:\n";
            foreach (string hobby in hobbies)
            {
                bio += $"- {hobby}\n";
            }
            return bio;
        }
        //public mehtod with a string array parameter
        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }
    }
}
