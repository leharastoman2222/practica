using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.MappingViews;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void enter_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var user = Instances.db.Пользователь.FirstOrDefault(q => q.логин.Equals(login_text.Text) && q.пароль.Equals(password_text.Password));
                    if (user != null)
                {
                    Window newWindow = new Window1();
                    this.Close();
                    newWindow.Show();
                }
                else
                {
                    MessageBox.Show("NO");
                }
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HYET", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
        }
    }
}
