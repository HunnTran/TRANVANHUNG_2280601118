using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaptrenlop
{
    internal class DanhSachHS
    {
        private string MSSV;
        private string Name;
        private int Age;

        public string mssv { get => MSSV; set => MSSV = value;}
        public string name { get => Name; set => Name = value; }
        public int age { get => Age; set => Age = value; }

        public DanhSachHS() 
        {
            
        }

        public DanhSachHS(string MSSV, string Name, int Age)
        {
            this.MSSV = MSSV;
            this.Name = Name;
            this.Age = Age;
        }

        public void Input()
        {
            Console.Write("Nhap MSSV: "); MSSV = Console.ReadLine();
            Console.Write("Nhap ho ten: "); Name = Console.ReadLine();
            Console.Write("Nhap tuoi: "); Age = int.Parse(Console.ReadLine()); // thu vien convert kieu => float
            
        }

        public void Output()
        {
            Console.WriteLine("MSSV: {0}, Ho Ten: {1}, Tuoi: {2}", this.MSSV, this.Name, this.Age);
        }
    }
}
