using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
           Student ogrenci= new Student();//obje yaratır heap in class bölgesinde
            object obj = new Student();//neden? c# da en temel sınıf objectir. Tüm tipler objectiveden türer.
            ogrenci.name = "mustafa";
            ogrenci.note = 1;
            ogrenci.address = "bakırkoy";

            Console.WriteLine("student name: " +ogrenci.name);
            Console.WriteLine("student note: " +ogrenci.note);
            Console.WriteLine("student address: " +ogrenci.address);

            Student tembelOgrenci = new Student();
            tembelOgrenci = ogrenci;

            Console.WriteLine(tembelOgrenci.name);
        }
    }
        class Student
        {
        //ad,
        //not
        //adres
        //okula gider
        //field
        public string name;//field denir
        public int note;//field denir

        //properties
        public string _address;
        public string address
        {
            get
            {
                return _address;

            }
            set
            {
                _address = value;
            }
        }
        //methods
        public void DoHomeWork()
        {

        }
        public void print()
        {

        }
    }
    
}
