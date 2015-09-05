using FirstFloor.ModernUI.Presentation;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstFloor.ModernUI.App.Content
{
    /// <summary>
    /// Interaction logic for SettingsAppearance.xaml
    /// </summary>
    public partial class SettingsAppearance : UserControl
    {
        public SettingsAppearance()
        {
            InitializeComponent();

            // a simple view model for appearance configuration
            var model = new SettingsAppearanceViewModel();
            this.DataContext = model;
            foreach(var t in model.Themes)
            {
                Debug.WriteLine(t.DisplayName);
            }

            //SetTheme("dark");
        }

        public void SetTheme(string name)
        {
            var model = this.DataContext as SettingsAppearanceViewModel;
            foreach (var t in model.Themes)
            {
                Debug.WriteLine(t.DisplayName);
                if (name == t.DisplayName)
                {
                    model.SelectedTheme = t;
                }
            }
        }
    }
}
