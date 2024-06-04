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

namespace AppUsers
{
    /// <summary>
    /// Логика взаимодействия для PerfomanceView.xaml
    /// </summary>
    public partial class PerfomanceView : Window
    {
        ApplicationContext db;
        User _user_now;
        public PerfomanceView(User user_now)
        {
            InitializeComponent();
            DataContext = this;
            db = new ApplicationContext();
            _user_now = user_now;
            DGridActors.ItemsSource = db.Actors.ToList();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            PersonWindow windowAuth = new PersonWindow(_user_now);
            windowAuth.Show();
            this.Close();
        }
    }
}
