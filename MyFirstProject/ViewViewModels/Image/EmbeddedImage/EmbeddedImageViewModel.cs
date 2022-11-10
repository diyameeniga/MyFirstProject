using MyFirstProject.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModels.Image.EmbeddedImage
{
    class EmbeddedImageViewModel : BaseViewModel
    {
        public ImageSource EmbeddedImageSrc {get; set;}

        public EmbeddedImageViewModel()
        {
            Title = Titles.EmbeddedImageTitle;
            this.GetEmbeddedImageSrc();
        }

        private void GetEmbeddedImageSrc()
        {
            EmbeddedImageSrc = ImageSource.FromResource("MyFirstProject.Images.placeimg_640_480_tech.jpg");
        }
    }
}
