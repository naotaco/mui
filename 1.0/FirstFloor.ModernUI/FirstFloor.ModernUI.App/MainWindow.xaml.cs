using FirstFloor.ModernUI.App.Content;
using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace FirstFloor.ModernUI.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow  
    {
        SettingsAppearanceViewModel appearance_manager = new SettingsAppearanceViewModel();


        public MainWindow()
        {
            InitializeComponent();
            
            SetTheme("dark");
            SetAccentColor();
        }

        public void SetTheme(string name)
        {
            foreach (var t in appearance_manager.Themes)
            {
                Debug.WriteLine(t.DisplayName);
                if (name == t.DisplayName)
                {
                    appearance_manager.SelectedTheme = t;
                }
            }
        }

        public void SetAccentColor()
        {
            appearance_manager.SelectedAccentColor = Color.FromRgb(0xd8, 0x00, 0x73);
        }
    }
}
