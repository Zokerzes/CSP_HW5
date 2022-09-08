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

		Journal()
		{
			Employee[] employees = new Employee[1];
			employees[0] = new Employee();
            _numberOfEmployees = employees.Length;

        }
		Journal(int numberEmp, params string[] name)
		{
			Employee[] employees = new Employee[numberEmp];
			int id = -1;
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
            Array.Resize(ref journal._employees, numberAdd);
			journal._employees[oldSize] = new Employee();
            return journal;
        }


    }









	internal class Program
	{
		static void Main(string[] args)
		{

		}
	}
}
