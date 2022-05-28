using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace eksam.Model
{
    public class Category : INotifyPropertyChanged
    {
        private string _image;
        private string _name;
        private string _subCategory;

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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
