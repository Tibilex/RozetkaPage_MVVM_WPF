using eksam.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace eksam.ViewModel
{
    public class ViewModelCategory : INotifyPropertyChanged
    {
        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<Category> AdvancedCategories { get; set; }
        public ObservableCollection<Category> Categories2 { get; set; }
        public static List<string> pc = new List<string>()
        {
            "SSD", "Системы охлаждения", "Видеокарты", "Оперативная память", "Процессоры", "материнские платы", "Жесткие диски и дисковые массивы", "Блоки питания"
        };
        public static List<string> network = new List<string>()
        {
            "Маршрутизаторы", "Коммутаторы", "Сетевые адптеры", "Пасивное сетевое оборудование", "Беспроводные точки доступа", "Ретрансляторы Wi-Fi", "Патч-корды"
        };
        public static List<string> headfones = new List<string>()
        {
            "Наушники", "Уселители для наушников", "Аксессуары для наушников"
        };
        public static List<string> keyboardsAndMouses = new List<string>()
        {
            "Компьютерные мыши", "Игровые поверхности", "Клавиатуры", "Комплект. клавиатура и мышь", "Аксессуары для клавиатур и мышек"
        };
        public static List<string> acsesories = new List<string>()
        {
            "флеш память USB", "Хабы и кардридеры", "аксессуары для ПК и ноутбуков", "Комлектующие для ноутбуков", "Сетевые фильтры, адаптеры и удлинители", "Чехлы для планшетов", "Сумки, рюкзаки и чехлы для ноутбуков", "Чистящие средства"
        };
        public static List<string> office = new List<string>()
        {
            "МФУ/Принтеры", "Сканеры", "Расходные сатериалы для принтеров", "Доски, флипчарты"
        };
        public ViewModelCategory()
        {
            Categories = new ObservableCollection<Category>();
            AdvancedCategories = new ObservableCollection<Category>();
            Categories2 = new ObservableCollection<Category>();

            Categories.Add(new Category("/Resources/Category/noutbuki.png", "Ноутбуки"));
            Categories.Add(new Category("/Resources/Category/pc.png", "Компьютеры"));
            Categories.Add(new Category("/Resources/Category/monitory.png", "Мониторы"));
            Categories.Add(new Category("/Resources/Category/forGamers.png", "Gaming"));
            Categories.Add(new Category("/Resources/Category/planshety.png", "Планшеты"));
            Categories.Add(new Category("/Resources/Category/kabeli.png", "Кабели и переходники"));

            AdvancedCategories.Add(new Category("/Resources/Category/kompyuternye.png", "Компьютерные Комплектующие", pc));
            AdvancedCategories.Add(new Category("/Resources/Category/setevoe.png", "Сетевое оборудование", network));
            AdvancedCategories.Add(new Category("/Resources/Category/headphones.png", "Наушникик и аксессуары", headfones));
            AdvancedCategories.Add(new Category("/Resources/Category/klaviatury.png", "Клавиатуры и мыши", keyboardsAndMouses));
            AdvancedCategories.Add(new Category("/Resources/Category/aksessuari.png", "Аксессуары для электроники", acsesories));
            AdvancedCategories.Add(new Category("/Resources/Category/ofisnaya.png", "Оргтехника", office));

            Categories2.Add(new Category("/Resources/Category/akustic.png", "Акустические системы"));
            Categories2.Add(new Category("/Resources/Category/programmnoe.png", "Программное обеспечение"));
            Categories2.Add(new Category("/Resources/Category/graphPlanshety.png", "Графические планшеты"));
            Categories2.Add(new Category("/Resources/Category/mikrofony.png", "Микрофоны"));
            Categories2.Add(new Category("/Resources/Category/servernoe.png", "Серверное оборудование"));
            Categories2.Add(new Category("/Resources/Category/interaktivnoe.png", "Интерактивное оборудование"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
