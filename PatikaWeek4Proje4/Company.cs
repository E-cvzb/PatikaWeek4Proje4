using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4Proje4
{
    public abstract class Company // Soyut olarak olarak kişinin bilgileri tanımlanır 
    {
        string _name;
        string _surname;
        
        string name {  get; set; }
        string surname {  get; set; }
        public virtual void Info()//kişinin bilgileri metot ile tanımlanır 
        {
            _name = name;
            _surname = surname;

           
        }
        public virtual void DutyInfo()//kişinin meslek bilgisi
        {
            Console.WriteLine("Lütfen ne iş yaptığınızı söyleyiniz");
            Console.ReadLine();
        }

    }
   public class Hasan : Company//hasan sınıfı company in alt sınıfı olmu oldu
    {
        public override void Info()
        {
            Console.WriteLine("Hasan Çıldırmış");
        }
        public override void DutyInfo()
        {
            base.DutyInfo();// mesleğini ekrena yazdırma
        }
    }
    public class Merve : Company
    {
        public override void Info()
        {
            Console.WriteLine("Merve Kara");
        }
        public override void DutyInfo()
        {
            base.DutyInfo();
        }
    }
}
