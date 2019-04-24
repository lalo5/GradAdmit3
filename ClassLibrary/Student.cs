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
        private Address StudentAddress;
        private Concentration StudentConcentration;

		//instance constructor 
		public Student(string e_Num, string f_Name, string m_Name, string l_Name, int hours, string email, Address AddrIn, Concentration ConcentrationIn)
		{
			E_Num = e_Num;
			F_Name = f_Name;
			M_Name = m_Name;
			L_Name = l_Name;
			Hours = hours;
			Email = email;
			this.StudentAddress = new Address(AddrIn);
            this.StudentConcentration = new Concentration(ConcentrationIn);
		}

        public Student()
        {
            E_Num = "Not Entered";
            F_Name = "No Name";
            M_Name = "Not Entered";
            L_Name = "Not Entered";
            Hours = 0;
            Email = "Not Entered";
            this.StudentAddress = new Address();
            this.StudentConcentration = new Concentration();
        }//end Student()

		//copy constructor 
		public Student(Student stud)
		{
			E_Num = stud.E_Num;
			F_Name = stud.F_Name;
			M_Name = stud.M_Name;
			L_Name = stud.L_Name;
			Hours = stud.Hours;
			Email = stud.Email;
			this.StudentAddress = new Address( stud.StudentAddress);
            this.StudentConcentration = new Concentration(stud.StudentConcentration);
		}//end Student(Student)

        public Address GetAddress()
        {
            return this.StudentAddress;
        }//end GetAddress()

        public Concentration GetConcentration()
        {
            return this.StudentConcentration;
        }//end Concentration()

	}//end student
}
