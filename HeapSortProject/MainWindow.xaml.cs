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

namespace HeapSortProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<TextBlock> elementi = new List<TextBlock>(); 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            TextBlock temp = new TextBlock();
            int tempnum = 0;
            if(int.TryParse(MainIn.Text, out tempnum))
            {
                temp.Text = MainIn.Text;
                temp.Background = Brushes.Teal;
                PanelS.Children.Add(temp);
                temp.Width = 30;
                temp.HorizontalAlignment = HorizontalAlignment.Left;
                MainIn.Text = "";
                elementi.Add(temp);
            }
            else
            {
                MessageBox.Show("Molim vas unesite broj");
            }
            
        }

        private void RemoveClick(object sender, RoutedEventArgs e)
        {
            TextBlock temp = elementi.Where(item => item.Text == MainIn.Text).FirstOrDefault();
            PanelS.Children.Remove(temp);
            elementi.Remove(temp);
        }

        private void ClearClick(object sender, RoutedEventArgs e)
        {
            PanelS.Children.Clear();
        }
    }
}
