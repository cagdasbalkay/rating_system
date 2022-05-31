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
using System.Windows.Shapes;

namespace film_rating
{
    /// <summary>
    /// Interaction logic for Guncelle.xaml
    /// </summary>
    public partial class Guncelle : Window
    {
        public Guncelle()
        {
            InitializeComponent();
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { ID = 1, Movie = "John Doe",Genre = "Horror",ReleaseDate = new DateTime(1971, 7, 23) ,Rate = 5 });
            employees.Add(new Employee() { ID = 2, Movie = "Jane Doe", Genre = "Comedy", ReleaseDate = new DateTime(1974, 1, 17) ,Rate =3 });
            employees.Add(new Employee() { ID = 3, Movie = "Sammy Doe", Genre = "Sci-Fi", ReleaseDate = new DateTime(1991, 9, 2) ,Rate = 1 });

            dgEmployee.ItemsSource = employees;
        }
        public class Employee
        {
            public int ID { get; set; }

            public string Movie { get; set; }

            public string Genre { get; set; }

            public DateTime ReleaseDate { get; set; }

            public int  Rate { get; set; }
        }
    }
}
