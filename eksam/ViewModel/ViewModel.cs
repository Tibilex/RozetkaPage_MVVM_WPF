using eksam.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace eksam.ViewModel
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Category> Categories { get; set; }
        //public ObservableCollection<Category> Categories { get; set; }

        public ViewModel()
        {
            Categories = new ObservableCollection<Category>();
            Categories.Add(new Category("/Resources/Category/noutbuki.png", "Ноутбуки"));
            Categories.Add(new Category("/Resources/Category/pc.png", "Компьютеры"));
            Categories.Add(new Category("/Resources/Category/monitory.png", "Мониторы"));
            Categories.Add(new Category("/Resources/Category/forGamers.png", "Gaming"));
            Categories.Add(new Category("/Resources/Category/planshety.png", "Планшеты"));
            Categories.Add(new Category("/Resources/Category/kabeli.png", "Кабели и переходники"));
            Categories.Add(new Category("/Resources/Category/kompyuternye.png", "Компьютерные Комплектующие"));
            Categories.Add(new Category("/Resources/Category/setevoe.png", "Сетевое оборудование"));
            Categories.Add(new Category("/Resources/Category/headphones.png", "Наушникик и аксессуары"));
            Categories.Add(new Category("/Resources/Category/klaviatury.png", "Клавиатуры и мыши"));
            Categories.Add(new Category("/Resources/Category/aksessuari.png", "Аксессуары для электроники"));
            Categories.Add(new Category("/Resources/Category/ofisnaya.png", "Оргтехника"));
            Categories.Add(new Category("/Resources/Category/akustic.png", "Акустические системы"));
            Categories.Add(new Category("/Resources/Category/programmnoe.png", "Программное обеспечение"));
            Categories.Add(new Category("/Resources/Category/graphPlanshety.png", "Графические планшеты"));
            Categories.Add(new Category("/Resources/Category/mikrofony.png", "Микрофоны"));
            Categories.Add(new Category("/Resources/Category/servernoe.png", "Серверное оборудование"));
            Categories.Add(new Category("/Resources/Category/interaktivnoe.png", "Интерактивное оборудование"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
