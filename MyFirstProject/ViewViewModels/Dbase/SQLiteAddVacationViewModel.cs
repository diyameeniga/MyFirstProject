﻿using MyFirstProject.Models;
using MyFirstProject.Patterns.Repositories;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Dbase
{
    public class SQLiteAddVacationViewModel: BaseViewModel
    {
        public SQLiteAddVacationViewModel() { }
        public Vacation VacationCollection { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int Visited { get; set; }
        public int ID { get; set; }

        public string ButtonText { get; set; }

        public SQLiteAddVacationViewModel(Vacation vacation)
        {
            if(vacation != null)
            {
                this.VacationCollection = vacation;
                this.ID = vacation.ID;
                this.Country = vacation.Country;
                this.City = vacation.City;
                this.Visited = vacation.Visited;

                ButtonText = "Update";
            }
            else
            {
                vacation = new Vacation();

                ButtonText = "Save";
            }
        }

        public Command<Vacation> PerformSave
        {
            get
            {
                return new Command<Vacation>(async (Vacation vacation) =>
               {
                   try
                   {
                       if (ButtonText == "Save")
                       {
                           vacation = new Vacation();
                           vacation.ID = this.ID;
                           vacation.Country = this.Country;
                           vacation.City = this.City;
                           vacation.Visited = this.Visited;

                           //DependencyService allows Xamarin to invoke Native platform functionality
                           bool res = DependencyService.Get<ISQLite>().SaveVacation(vacation);
                           if(res)
                           {
                               MessagingCenter.Send<Vacation>(vacation, "AddVacation");
                               await Application.Current.MainPage.Navigation.PopAsync();
                           }
                           else
                           {
                                await Application.Current.MainPage.DisplayAlert("Message", "Data Failed To Save", "Ok");
                           }
                       }
                       else
                       {
                           vacation = new Vacation();
                           vacation.ID = this.ID;
                           vacation.Country = this.Country;
                           vacation.City = this.City;
                           vacation.Visited = this.Visited;

                           bool res = DependencyService.Get<ISQLite>().UpdateVacation(vacation);
                           if (res)
                           {
                               MessagingCenter.Send<Vacation>(vacation, "AddVacation");
                               await Application.Current.MainPage.Navigation.PopAsync();
                           }
                           else
                           {
                               await Application.Current.MainPage.DisplayAlert("Message", "Data Failed To Update", "Ok");
                           }
                       }
                   }
                   catch (Exception ex)
                   {
                       await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
                   }
               });
            }
        }
    }
}
