using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Demo1.Model {
	public class Student : INotifyPropertyChanged {
		// Properties
		private string firstname;
		private string lastname;
		private string asioid;
		public string FirstName
		{
			get { return firstname; }
			set {
				if (firstname != value) {
					firstname = value;
					RaisePropertyChanged("FirstName");
					RaisePropertyChanged("FullName");
				}
			}
		}
		public string LastName
		{
			get { return lastname; }
			set {
				if (lastname != value) {
					lastname = value;
					RaisePropertyChanged("LastName");
					RaisePropertyChanged("FullName");
				}
			}
		}
		public string FullName {
			get {
				return firstname + " " + lastname;
			}
		}
		public string AsioId
		{
			get { return asioid; }
			set {
				if (asioid != value) {
					asioid = value;
					RaisePropertyChanged("AsioId");
				}
			}
		}
		// Constructors
		//-
		// Methods
		//.
		// Events
		public event PropertyChangedEventHandler PropertyChanged;
		private void RaisePropertyChanged(string property)
		{
			if (PropertyChanged != null) {
				PropertyChanged(this, new PropertyChangedEventArgs(property));
			}
		}
	}
}
