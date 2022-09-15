using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP_HW5
{
	//    Задание 1
	//Ранее в одном из практических заданий вы создавали
	//класс «Журнал». Добавьте к уже созданному классу инфор-
	//мацию о количестве сотрудников.Выполните перегрузку
	//+ (для увеличения количества сотрудников на указанную
	//величину), — (для уменьшения количества сотрудников
	//на указанную величину), == (проверка на равенство ко-
	//личества сотрудников), < и > (проверка на меньше или
	//больше количества сотрудников), != и Equals.Используйте
	//механизм свойств для полей класса.
	public class Journal //где он ("Ранее в одном...") не нашёл
    {
        public int id = -1;
        public class Employee
		{
			public int _id;
			public string _name;
			public Employee()
			{
				 _id = 0;
				_name = "Smit";
			}
			public Employee(int id, string name)
			{
				_id = id;
				_name = name;
			}
        }
		public int _numberOfEmployees;
		public Employee[] _employees;

		public Journal()
		{
		    Employee[] employees = new Employee[1];
			employees[0] = new Employee();
            _numberOfEmployees = employees.Length;

        }
        public Journal(int numberEmp, params string[] name)
		{
			Employee[] employees = new Employee[numberEmp];
			
			foreach (var item in employees)
			{
				item._id++;
				item._name = name[id];
			}
            _numberOfEmployees = employees.Length;
        }
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static Journal operator +(Journal journal, int numberAdd)
        {
			int oldSize = journal._employees.Length;
            Array.Resize(ref journal._employees, oldSize + numberAdd);
			for (int i = 0; i < numberAdd; i++)
			{
				oldSize++;
                journal._employees[oldSize-1] = new Employee();
            }
            journal._numberOfEmployees = journal._employees.Length;
            return journal;
        }
        public static Journal operator -(Journal journal, int numberSub)
        {
            int oldSize = journal._employees.Length;
            Array.Resize(ref journal._employees, oldSize - numberSub);
            journal._numberOfEmployees = journal._employees.Length;
            return journal;
        }
        public static bool operator ==(Journal j1, Journal j2)
        {
            return j1._numberOfEmployees == j2._numberOfEmployees;

        }
        public static bool operator !=(Journal j1, Journal j2)
        {
            return j1._numberOfEmployees != j2._numberOfEmployees;
        }
        public static bool operator >(Journal j1, Journal j2)
        {
            return j1._numberOfEmployees > j2._numberOfEmployees;
        }
        public static bool operator <(Journal j1, Journal j2)
        {
            return j1._numberOfEmployees < j2._numberOfEmployees;
        }
        public override string ToString()
        {
            return  $"\nИмя сотрудника: { Journal.Employee._id } Его id: {Journal.Employee._name}\nЗаработная плата: {_salary}";
        }
    }









	internal class Program
	{
		static void Main(string[] args)
		{

		}
	}
}
