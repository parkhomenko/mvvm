using mvvm.Utils;
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

namespace mvvm.Views
{
    /// <summary>
    /// Interaction logic for StudentsInformationView.xaml
    /// </summary>
    public partial class StudentsInformationView : UserControl
    {
        public StudentsInformationView()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string[] info = new string[] { tbFirst.Text, tbSecond.Text };

            TreeViewBase item = (TreeViewBase)StudentsTree.SelectedItem;
            item.EditInfo(info);
        }

        private void StudentsTree_SelectedItemChanged_1(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewBase item = (TreeViewBase)StudentsTree.SelectedItem;
            string[] info = item.GetInfo();
            tbFirst.Text = info[0];
            tbSecond.Text = info[1];
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string[] info = new string[] { tbFirst.Text, tbSecond.Text };

            TreeViewBase item = (TreeViewBase)StudentsTree.SelectedItem;
            item.AddInfo(info);
        }
    }
}