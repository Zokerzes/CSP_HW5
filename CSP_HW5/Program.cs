using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static CSP_HW5.Journal;

namespace CSP_HW5
{
    //    Задание 1 только его
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
        public int _id = 0; //количество сотрудников 

        public Journal()
        {

        }
        public Journal(int id)
        {
            this._id = id;
        }
        //public Journal()

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
            journal._id += numberAdd;
            return journal;
        }
        public static Journal operator -(Journal journal, int numberSub)
        {
            journal._id -= numberSub;
            return journal;
        }
        public static bool operator ==(Journal j1, Journal j2)
        {
            return j1._id == j2._id;
        }
        public static bool operator !=(Journal j1, Journal j2)
        {
            return j1._id != j2._id;
        }

        public static bool operator >(Journal j1, Journal j2)
        {
            return j1._id > j2._id;
        }
        public static bool operator <(Journal j1, Journal j2)
        {
            return j1._id < j2._id;
        }
        public override string ToString()
        {
            return $"колличество сотрудников: {this._id}";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            Journal j1 = new Journal(2);
            Journal j2 = new Journal(3);

            Console.WriteLine($"журнал J1 -{j1.ToString()}\tжурнал J2 -{j2.ToString()}\n");
            j1 += 2;
            Console.WriteLine("j1 += 2\n");
            Console.WriteLine($"журнал J1 -{j1.ToString()}\tжурнал J2 -{j2.ToString()}\n");

        }
    }
}
