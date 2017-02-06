/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP Labra 9 - Tehtävä 2
 * Kuvaus:
    Tee ohjelma, jolla voidaan muuttaa euroja markoiksi ja päinvastoin.
    Pyöristä raha-arvot tulostuksessa siten, että käytössä on vain kahden desimaalin tarkkuus. 
 * Pvm: 6.2.2017
 */

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

namespace Harjoitus2 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow()
		{
			InitializeComponent();
		}

		private void EuroButtonClicked(object sender, RoutedEventArgs e)
		{
			double initialValue, outputValue;
			bool isValid;
			isValid = double.TryParse(InputEuros.Text, out initialValue);
			if (isValid == true) {
				outputValue = (initialValue * 10);
				CrownsOutput.Text = outputValue.ToString("0.00");
				LogMessages.Text = "Success";
			}
			else {
				LogMessages.Text = "Invalid input!";
			}
		}

		private void CrownButtonClicked(object sender, RoutedEventArgs e)
		{
			double initialValue, outputValue;
			bool isValid;
			isValid = double.TryParse(InputCrowns.Text, out initialValue);
			if (isValid == true) {
				outputValue = (initialValue / 10);
				EurosOutput.Text = outputValue.ToString("0.00");
				LogMessages.Text = "Success";
			}
			else {
				LogMessages.Text = "Invalid input!";
			}
		}
	}
}
