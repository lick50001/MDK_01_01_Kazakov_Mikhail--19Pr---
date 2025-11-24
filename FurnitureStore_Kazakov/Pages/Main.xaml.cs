using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FurnitureStore_Kazakov.Classes;

namespace FurnitureStore_Kazakov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public List<Item> items = new List<Item>();
        public Main()
        {
            InitializeComponent();
            items.Add(new Item("Шкаф", 20000, "m48w2wyujo2uwb87n4p6p7p3ornu2mo4.jpg"));
            LoadItems();
        }

        public void LoadItems(){
            parent.Children.Clear();

            foreach (Item item in items){
                parent.Children.Add(new Elements.Item(item));
            }
        }
    }
}
