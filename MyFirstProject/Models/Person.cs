using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.Models
{
    class Person
    {
        public string Name { get; set; }

        public string Player { get; set; }

        public ImageSource URL { get; set; }

        public Person() {}
        public Person(string name)
        {
            Name = name;
        }
        public Person(string name, string player, string url)
        {
            Name = name;
            Player = player;
            URL = SetImageSrc(url);
        }
        public static List<Person> getURLs()
        {
            return new List<Person>
            {
                new Person("Football", "Tom Brady", "https://static01.nyt.com/images/2020/12/02/sports/02streeter-sot01/merlin_180328275_b86a2377-725f-45b2-970f-2c6493acf69b-superJumbo.jpg"),
                new Person("Basketball", "Lebron James", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2a/Carter_vs_Gasol%2C_Lakers_vs_Magic.jpg/640px-Carter_vs_Gasol%2C_Lakers_vs_Magic.jpg"),
                new Person("Soccer", "Alex Morgan", "https://dynaimage.cdn.cnn.com/cnn/c_fill,g_auto,w_1200,h_675,ar_16:9/https%3A%2F%2Fcdn.cnn.com%2Fcnnnext%2Fdam%2Fassets%2F220802143927-usa-england-women-world-cup-2019.jpg"),
                new Person("Baseball", "Bobby Bob", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/Mookie_Betts_hitting_the_ball_%2836478781664%29.jpg/640px-Mookie_Betts_hitting_the_ball_%2836478781664%29.jpg"),
                new Person("Gymnastics", "Simone Biles", "https://s.hdnux.com/photos/01/27/06/22/22832281/4/rawImage.jpg"),
                new Person("Dance", "Maddie Zeigler", "https://i.guim.co.uk/img/media/1bb31654c7ada0b32268489b347bbe9067c72fdc/164_256_3724_2234/master/3724.jpg?width=1200&quality=85&auto=format&fit=max&s=edf0d8f3cdffbb5a6a3794bae33842a1")

            };
        }
        private ImageSource SetImageSrc(string picture)
        {
            var imgsrc = new UriImageSource { Uri = new Uri(picture) };
            imgsrc.CachingEnabled = false;
            imgsrc.CacheValidity = TimeSpan.FromHours(1);

            return imgsrc;
        }
        public static List<Person> getNames()
        {
            return new List<Person>
            {
                new Person("Football"),
                new Person("Basketball"),
                new Person("Soccer"),
                new Person("Baseball"),
                new Person("Gymnastics"),
                new Person("Dance"),
                
            };
        }
    }
}
