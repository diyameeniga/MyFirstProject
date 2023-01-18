using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.Models
{
    class Cars
    {
        public string Name { get; set; }

        public ImageSource URL { get; set; }

        public Cars() { }
        public Cars(string name) {}
        public Cars(string name, string url) 
        {
            Name = name;
            URL = SetImageSrc(url);
        }
       
        public static List<Cars> getURLs()
        {
            return new List<Cars>
            {
                new Cars("2018 Audi S3", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.cars.com%2Fresearch%2Faudi-s3-2018%2F&psig=AOvVaw2SX-q4RW4_oUZBkUN3wSHg&ust=1674144584542000&source=images&cd=vfe&ved=0CAwQjRxqFwoTCLipr93A0fwCFQAAAAAdAAAAABAD"),
                new Cars("2019 Audi A4", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.newcartestdrive.com%2Freviews%2F2019-audi-a4%2F&psig=AOvVaw3L20cKehO8r2ylWB2u2SVt&ust=1674144776218000&source=images&cd=vfe&ved=0CAwQjRxqFwoTCIiT-LjB0fwCFQAAAAAdAAAAABAD"),
                new Cars("2020 Audi Q5", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.drivegarber.com%2Fblog%2F2020-models%2F2020-audi-q5-boosts-safety-and-gets-new-rollers%2F&psig=AOvVaw2xMi2Jr2YOPh7j_vsrgoLc&ust=1674144798496000&source=images&cd=vfe&ved=0CAwQjRxqFwoTCLifm8bB0fwCFQAAAAAdAAAAABAD" ),
                new Cars("2021 Audi Q7", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.jdpower.com%2Fcars%2Fexpert-reviews%2F2021-audi-q7-review&psig=AOvVaw21LIU0AeV2G_jWSQAmUml9&ust=1674144836832000&source=images&cd=vfe&ved=0CAwQjRxqFwoTCNiU-dXB0fwCFQAAAAAdAAAAABAI"),
                new Cars("2022 Audi R8", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.motortrend.com%2Freviews%2F2022-audi-r8-v10-performance-rwd-first-test-review%2F&psig=AOvVaw0ICoCtINtPHHLT_MoN2Cb_&ust=1674144861213000&source=images&cd=vfe&ved=0CAwQjRxqFwoTCMiRv-DB0fwCFQAAAAAdAAAAABAD" ),
            };
        }
        private ImageSource SetImageSrc(string picture)
        {
            var imgsrc = new UriImageSource { Uri = new Uri(picture) };
            imgsrc.CachingEnabled = false;
            imgsrc.CacheValidity = TimeSpan.FromHours(1);

            return imgsrc;
        }
        public static List<Cars> getNames()
        {
            return new List<Cars>
            {
                new Cars("2018 Audi S3"),
                new Cars("2019 Audi A4"),
                new Cars("2020 Audi Q5"),
                new Cars("2021 Audi Q7"),
                new Cars("2022 Audi R8"),
            };
        }
    }
}
