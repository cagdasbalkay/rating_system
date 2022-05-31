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

namespace film_rating
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lbxMovie.Items.Add(tbxName.Text + "        " + cbxGenre.Text + "        " + datePickerMovie.Text + "        " + cbxRating.Text);
            cmbx();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lstbx();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            lbxMovie.Items.RemoveAt

       (lbxMovie.Items.IndexOf(lbxMovie.SelectedItem));
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Guncelle git = new Guncelle();
            git.ShowDialog();
        }

        public void cmbx()
        {
            cbxRating.ClearValue(ComboBox.SelectedItemProperty);
            cbxGenre.ClearValue(ComboBox.SelectedItemProperty);
            tbxName.Clear();
            datePickerMovie.ClearValue(DatePicker.SelectedDateProperty);
        }

        public void lstbx()
        {
            lbxMovie.Items.Clear();
        }
    }
}
