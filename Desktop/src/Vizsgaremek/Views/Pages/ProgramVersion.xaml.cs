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

using Vizsgaremek.Views.Navigation;

using Vizsgaremek.ViewModels;

namespace Vizsgaremek.Views.Pages
{
    /// <summary>
    /// Interaction logic for ProgramVersion.xaml
    /// </summary>
    public partial class ProgramVersion : UserControl
    {
        ProgramVersionViewModel programVersionViewModel;

        public ProgramVersion()
        {
            InitializeComponent();
            programVersionViewModel = new ProgramVersionViewModel();
            this.DataContext = programVersionViewModel;
        }

        // Vissza ikonra kattintva visszatér a nyitóoldalra
        private void Image_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            // Statikus osztály ezért az osztály nevét írjuk
            Navigate.Navigation(welcomePage);
        }

        private void btAuthors_Click_1(object sender, RoutedEventArgs e)
        {
            txtAuthors.Text = programVersionViewModel.Authors;
        }
    }
}
