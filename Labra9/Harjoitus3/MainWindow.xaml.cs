/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Harjoitus: OOP Labra 9 - Tehtävä 3
 * Kuvaus:
    Keski-suomalainen pieni ikkunoita valmistava yritys Oy K-S Windows Ab tarvitsee yksinkertaista sovellusta, 
    jolla tehtaan työntekijät voivat laskea asiakkaan tilaamista ikkunoista ikkunalasin ja karmipuiden menekin.
    Käyttäjä syöttää ikkunan leveyden ja korkeuden millimetreinä sekä karmipuun leveyden (oletusarvo 45 mm).
    Tämän jälkeen hän kliksauttaa laske-painiketta ja sovellus laskee ikkunalasin pinta-alan sekä tarvittavan karmipuiden piirin. 
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

namespace Harjoitus3 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		private int hWindow, wWindow, wFrame, resultPerimeter, resultArea;
		bool isNumhWindow, isNumwWindow, isNumwFrame;

		private void CalculateArea_Click(object sender, RoutedEventArgs e)
		{
			isNumhWindow = int.TryParse(input_hWindow.Text, out hWindow);
			isNumwWindow = int.TryParse(Input_wWindow.Text, out wWindow);
			isNumwFrame = int.TryParse(Input_wFrame.Text, out wFrame);

			if (isNumhWindow == true && isNumwWindow == true && isNumwFrame == true) {
				ErrorMessages.Text = "Success!";
				Calculations();
			} else if (isNumwFrame == false) {
				Input_wFrame.Text = "45";
				wFrame = 45;
				ErrorMessages.Text = "Window frame defaults to 45mm!";
				Calculations();
			} else {
				ErrorMessages.Text = "Invalid input";
			}
		}

		private void Calculations()
		{
			resultArea = (hWindow + wFrame) * (wWindow + wFrame);
			resultPerimeter = (2 * (hWindow + wFrame)) + (wWindow * 2);
			string tmp1 = string.Format("{0} mm^2", resultArea);
			string tmp2 = string.Format("{0} mm", resultPerimeter);
			output_WindowArea.Text = tmp1;
			output_FramePerimeter.Text = tmp2;
		}


		public MainWindow()
		{
			InitializeComponent();
		}
	}
}
