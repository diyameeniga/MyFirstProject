using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MyFirstProject.ViewViewModels.Controls.Picker
{
    class PickerResultsViewModel: BaseViewModel
    {
      /*  public ObservableCollection<Cars> CarsCollection { get; }
        private List<Cars> _carsList;
        public string SelectedCar; */

        public List<String> CarsList { get; set; }
        public PickerResultsViewModel()
        {
            Title = Titles.PickerResultsViewTitle;
            //CarsCollection = new ObservableCollection<Cars>();
            // _carsList = Cars.getURLs();
            //this.LoadCars();

            //  SelectedCar = pickerXAML.SelectedItem;
        }

        public static List<Cars> getNames()
        {
            return new List<Cars>
            {
                new Cars("2018 Audi S3",
                    "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.cars.com%2Fresearch%2Faudi-s3-2018%2F&psig=AOvVaw2SX-q4RW4_oUZBkUN3wSHg&ust=1674144584542000&source=images&cd=vfe&ved=0CAwQjRxqFwoTCLipr93A0fwCFQAAAAAdAAAAABAD"),
                new Cars("2019 Audi A4",
                    "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.newcartestdrive.com%2Freviews%2F2019-audi-a4%2F&psig=AOvVaw3L20cKehO8r2ylWB2u2SVt&ust=1674144776218000&source=images&cd=vfe&ved=0CAwQjRxqFwoTCIiT-LjB0fwCFQAAAAAdAAAAABAD"),
                new Cars("2020 Audi Q5",
                    "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.drivegarber.com%2Fblog%2F2020-models%2F2020-audi-q5-boosts-safety-and-gets-new-rollers%2F&psig=AOvVaw2xMi2Jr2YOPh7j_vsrgoLc&ust=1674144798496000&source=images&cd=vfe&ved=0CAwQjRxqFwoTCLifm8bB0fwCFQAAAAAdAAAAABAD"),
                new Cars("2021 Audi Q7",
                    "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.jdpower.com%2Fcars%2Fexpert-reviews%2F2021-audi-q7-review&psig=AOvVaw21LIU0AeV2G_jWSQAmUml9&ust=1674144836832000&source=images&cd=vfe&ved=0CAwQjRxqFwoTCNiU-dXB0fwCFQAAAAAdAAAAABAI"),
                new Cars("2022 Audi R8",
                    "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.motortrend.com%2Freviews%2F2022-audi-r8-v10-performance-rwd-first-test-review%2F&psig=AOvVaw0ICoCtINtPHHLT_MoN2Cb_&ust=1674144861213000&source=images&cd=vfe&ved=0CAwQjRxqFwoTCMiRv-DB0fwCFQAAAAAdAAAAABAD")
            };
        }

        /*   public void GetCarsList()
           {
               List<Cars> carnames = Cars.getNames();

               var car = Cars.getNames();

               CarsList = (from c in car
                           select c.Cars).ToList();
           }

      /*     private void LoadCars()
           {
               try
               {
                   CarsCollection.Clear();
                   foreach (var p in _carsList) //CHANGE THIS PART to make only one image show
                   {
                       CarsCollection.Add(p);
                   }
               }
               catch (Exception ex)
               {
                   Debug.WriteLine(ex);
               }
           }*/
    }
}
