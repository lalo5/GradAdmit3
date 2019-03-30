using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    /// <summary>
    /// The class providing basic information regarding an applying graduate (name, address, etc)
    /// </summary>
    public class Student
    {
		//variables
		private string E_Num { get; }
		private string F_Name { get; }
		private string M_Name { get; }
		private string L_Name { get; }
		private int Hours { get; }
		private string Email { get; }
		private int Address_ID { get; }
        private Concentration StudentConcentration;

		//instance constructor 
		public Student(string e_Num, string f_Name, string m_Name, string l_Name, int hours, string email, int address_ID, Concentration ConcentrationIn)
		{
			E_Num = e_Num;
			F_Name = f_Name;
			M_Name = m_Name;
			L_Name = l_Name;
			Hours = hours;
			Email = email;
			Address_ID = address_ID;
            this.StudentConcentration = ConcentrationIn;
		}

		//copy constructor 
		public Student(Student stud)
		{
			E_Num = stud.E_Num;
			F_Name = stud.F_Name;
			M_Name = stud.M_Name;
			L_Name = stud.L_Name;
			Hours = stud.Hours;
			Email = stud.Email;
			Address_ID = stud.Address_ID;
            this.StudentConcentration = new Concentration(stud.StudentConcentration);
		}//end Student(Student)

	}//end student
}
