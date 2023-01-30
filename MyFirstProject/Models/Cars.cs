using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.Models
{
    public class Cars
    {
       public string Car { get; set; }
       public string Image { get; set; }

        public Cars() { }

        public Cars(string name) 
        {
            Car = name;
        }

        public Cars(string name, string img) 
        {
            Car = name;
            Image = img;
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

        public static List<Cars> getCars()
        {
            return new List<Cars>
            {
                new Cars("2018 Audi S3", "https://images.fitmentindustries.com/web-compressed/369665-7-2018-s3-audi-hr-lowering-springs-rotiform-las-r-matte-black.jpg"),
                new Cars("2019 Audi A4", "https://images.drive.com.au/driveau/image/upload/c_fill,f_auto,g_auto,h_674,q_auto:eco,w_1200/cms/uploads/4g7C7BDeTm2i3mtfyqjB"),
                new Cars("2020 Audi Q5", "https://media.ed.edmunds-media.com/audi/q5/2020/oem/2020_audi_q5_4dr-suv_prestige-45-tfsi-quattro_fq_oem_1_1600.jpg" ),
                new Cars("2021 Audi Q7", "https://consumerguide.com/wp-content/uploads/bfi_thumb/large-2020-audi-q7-6645-old6080lmrazog9285gb307i4uwwfdy7v5nhsray5c.jpg"),
                new Cars("2022 Audi R8", "https://hips.hearstapps.com/hmg-prod/images/2023-audi-r8-gt-front-three-quarters-motion-3-1664827965.jpg?crop=0.585xw:0.438xh;0.0785xw,0.353xh&resize=1200:*" ),
            };
        }
    }
}
