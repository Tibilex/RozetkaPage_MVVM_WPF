using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace eksam.Model
{
    public class Category : INotifyPropertyChanged
    {
        private string _image;
        private string _name;
        private string _subCategory;
        private List<string> _strings;

        public List<string> Strings
        {
            get { return _strings; }
            set 
            { 
                _strings = value; 
                OnPropertyChanged("Strings");
            }
        }
        public string SubCategory
        {
            get { return _subCategory; }
            set 
            { 
                _subCategory = value;
                OnPropertyChanged("SubCategory");
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

        public Category(string image, string name)
        {
            Image = image;
            Name = name;
        }

        public Category(string image, string name, List<string> collection)
        {
            Image = image;
            Name = name;
            Strings = collection;
        }

        

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
