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

namespace Harjoitus1 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		private string item;
		public MainWindow()
		{
			InitializeComponent();
		}

		private void BuyButton_Clicked(object sender, RoutedEventArgs e)
		{
			foreach (object control in ChkList.Children) {
				if (control is CheckBox) {
					CheckBox checBox = (CheckBox)control;
					if ((bool)checBox.IsChecked) {
						item += checBox.Content + " ";
					}
				}
				txtShopListOutput.Text = item;
			}
		}
	}
}
