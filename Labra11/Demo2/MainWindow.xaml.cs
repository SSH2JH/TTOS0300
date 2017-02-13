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
using System.Collections.ObjectModel;
using JAMK.ICT;

namespace Demo {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		JAMK.ICT.HockeyLeague league;
		ObservableCollection<JAMK.ICT.HockeyTeam> teams;
		int counter = 0;
		public MainWindow()
		{
			InitializeComponent();
			IniMyStuff();
		}
		/// <summary>
		/// Here lays own control initialization
		/// </summary>
		private void IniMyStuff()
		{
			List<string> muuvit = new List<string>();
			muuvit.Add("Halloween");
			muuvit.Add("Jaws");
			muuvit.Add("Hangover");
			cmbMovies.ItemsSource = muuvit;
			league = new JAMK.ICT.HockeyLeague();
			teams = league.GetTeams();
			cmbTeams.ItemsSource = teams;
			
		}
		/// <summary>
		/// Defining stackpanel datacontext.
		/// Demo1: Datacontext is object
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnBind_Click(object sender, RoutedEventArgs e)
		{
			//HockeyTeam team = new HockeyTeam("KeuPa", "Keuruu");
			//spRight.DataContext = team;
			spRight.DataContext = teams[counter];
		}
	}
}
