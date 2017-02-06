/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP Labra 9 - Tehtävä 1
 * Kuvaus:
 *		 Opiskelija on saanut itselleen unelma kesätyön vilkasliikenteisen kadun varrelta. 
 *		 Hänen tulee laskea ohi menevät henkilö- ja kuorma-autot. Laadi opiskelijalle sovellus,
 *		 jolla hän voi laskea helposti ohi menneet autot.
 *		 Painikkeita painettaessa ko. kulkuneuvon osoittama lukumäärä kasvaa yhdellä. 
 * Pvm: 6.2.2017
 */

using System;
using System.Windows;

namespace Harjoitus1 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		private int trucs = 0;
		private int cars = 0;
		public MainWindow()
		{
			InitializeComponent();
		}

		private void truckButton_click(object sender, RoutedEventArgs e)
		{
			trucs++;
			PrintTrucs.Text = Convert.ToString(trucs);
		}

		private void carbutton_click(object sender, RoutedEventArgs e)
		{
			cars++;
			PrintCars.Text = Convert.ToString(cars);
		}
	}
}
