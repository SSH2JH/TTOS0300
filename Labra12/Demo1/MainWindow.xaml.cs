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

namespace Demo1 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		Demo1.ViewModel.StudentViewModel svmo = new ViewModel.StudentViewModel();
		
		public MainWindow()
		{
			InitializeComponent();
			svmo.LoadStudents();
		}

		private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
		{
			StudentViewControl.DataContext = svmo;
		}

		private void dgStudents_Loaded(object sender, RoutedEventArgs e)
		{
			dgStudents.DataContext = svmo.Students;
		}

		private void btnAdd_Click(object sender, RoutedEventArgs e)
		{
			// Luodaan observablecollectioniin uusi student olio
			Demo1.Model.Student uusi = new Model.Student();
			uusi.FirstName = txtFirstName.Text;
			uusi.LastName = txtLastName.Text;
			uusi.AsioId = txtAsioId.Text;
			svmo.Students.Add(uusi);
			// Tyhjätään tekstboxit
			txtFirstName.Text = ""; txtLastName.Text = ""; txtAsioId.Text = "";
		}
	}
}
