using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace eksam.Model
{
    public class Product : INotifyPropertyChanged
    {
        private string _image;
        private string _imageHover;
        private string _name;
        private int _price;
        private string _feedback;
        private string _avaliable;

        public string ImageHover
        {
            get { return _imageHover; }
            set 
            { 
                _imageHover = value;
                OnPropertyChanged("ImageHover");
            }
        }
        public string Avaliable
        {
            get { return _avaliable; }
            set 
            { 
                _avaliable = value;
                OnPropertyChanged("Avaliable");
            }
        }
        public string Feedback
        {
            get { return _feedback; }
            set 
            { 
                _feedback = value; 
                OnPropertyChanged("Feedback");
            }
        }
        public int Price
        {
            get { return _price; }
            set 
            { 
                _price = value;
                OnPropertyChanged("Price");
            }
        }
        public string Name
        {
            get { return _name; }
            set 
            { 
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Image
        {
            get { return _image; }
            set 
            {
                _image = value;
                OnPropertyChanged("Image");
            }
        }

        public Product(string image, string imageHover, string name, int price, string feedback, string avaliable)
        {
            Image = image;
            ImageHover = imageHover;
            Name = name;
            Price = price;
            Feedback = feedback;
            Avaliable = avaliable;
        }

        public Product(string image, string name, int price, string feedback, string avaliable)
        {
            Image = image;
            Name = name;
            Price = price;
            Feedback = feedback;
            Avaliable = avaliable;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
