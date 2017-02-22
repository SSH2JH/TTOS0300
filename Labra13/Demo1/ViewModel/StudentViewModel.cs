﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo1.Model;
using System.Collections.ObjectModel;
using MySql.Data.MySqlClient;

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
		//metodi StudentViewModeliin jolla haetaan oppilastiedot mysql-palvemilta
		public void LoadStudentsFromMysql()
		{
			try {
				ObservableCollection<Student> students = new ObservableCollection<Student>();
				//luodaan yhteys labranetin mysql-palvelimelle
				string connStr = GetMysqlConnectionString();
				string sql = "SELECT firstname, lastname, asioid FROM student";
				using (MySqlConnection conn = new MySqlConnection(connStr)) {
					conn.Open();
					using (MySqlCommand cmd = new MySqlCommand(sql, conn))
					using (MySqlDataReader reader = cmd.ExecuteReader()) {
						while (reader.Read()) {
							Demo1.Model.Student s = new Model.Student();
							s.FirstName = reader.GetString(0);
							s.LastName = reader.GetString(1);
							students.Add(s);
						}
						Students = students;
					}
				}
			} catch {
				throw;
			}
		}
		private string GetMysqlConnectionString()
		{
			string pw = "ei tieda";
			string un = "ei tieda";
			return string.Format("Data source=mysql.labranet.jamk.fi;Initial Catalog=K8960_1;user={0};password={1}", un, pw);
		}
	}
}
