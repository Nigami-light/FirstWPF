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

namespace FirstWPF
{
    public partial class FirstPage : Page
    {
        private Random rnd;
        private static readonly string[] ImagePaths = 
        {
            "C:/Users/Mihail/source/repos/FirstWPF/FirstWPF/Images/Frame 1.jpg",
            "C:/Users/Mihail/source/repos/FirstWPF/FirstWPF/Images/Frame 2.jpg",
            "C:/Users/Mihail/source/repos/FirstWPF/FirstWPF/Images/Frame 3.jpg"
        };

        public FirstPage()
        {
            rnd = new Random();
            InitializeComponent();

            int rnd_idx = rnd.Next(ImagePaths.Length);
            string rnd_path = ImagePaths[rnd_idx];
            img.Source = new BitmapImage(new Uri(rnd_path));
        }

    }
}
