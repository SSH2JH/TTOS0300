using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo1.Model;
using System.Collections.ObjectModel;

namespace Demo1.ViewModel {
	class StudentViewModel {
		public ObservableCollection<Student> Students {	get; set; }
		public void LoadStudents()
		{
			ObservableCollection<Student> students = new ObservableCollection<Student>();
			// Lisätään esimerkin vuoksi muutama opiskelija, oikeassa sovelluksessa haettaisiin tietokannasta
			/*students.Add(new Student { FirstName = "Kalle", LastName = "Jalkanen", AsioId="A1234" });
			students.Add(new Student { FirstName = "Teppo", LastName = "Testaaja", AsioId="A2345" });
			students.Add(new Student { FirstName = "Tomi", LastName = "Tomminen", AsioId = "B1234" });
			students.Add(new Student { FirstName = "Emilia", LastName = "Nieminen", AsioId = "B2345" });*/
			Students = students;
		}
	}
}
