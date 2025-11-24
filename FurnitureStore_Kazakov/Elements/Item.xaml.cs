using System;
using System.Collections.Generic;
using System.IO;
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

namespace FurnitureStore_Kazakov.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Item(Classes.Item item)
        {
            InitializeComponent();

            if (item != null){
                if (File.Exists(Directory.GetCurrentDirectory() + "/Image/" + item.src))
                    image.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory()
                        + "/Image/" + item.src));
            }
            else
                image.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory()
                        + "/Image/EAP225-Outdoor(EU)1.0_01_normal_1511142332988w.jpg"));

            price.Content = item.price;
            name.Content = item.name;
        }
    }
}
