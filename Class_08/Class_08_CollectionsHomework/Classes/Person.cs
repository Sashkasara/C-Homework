using System;
using System.Collections.Generic;
using System.Text;

namespace Class_08_CollectionsHomework.Classes
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person(string firstName, string lastName, int age, Genre favoritMusic)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoritMusic;
            FavoriteSongs = new List<Song>();
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
