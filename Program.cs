using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace baitaptrenlop
{
    class Program
    {
        static void Main(string[] args)
        {

            List<DanhSachHS> studentList = new List<DanhSachHS>()
            {
                new DanhSachHS { mssv = "001", name = "An", age = 14 },
                new DanhSachHS { mssv = "002", name = "Binh", age = 16 },
                new DanhSachHS { mssv = "003", name = "Anh", age = 18 },
                new DanhSachHS { mssv = "004", name = "Lan", age = 17 },
                new DanhSachHS { mssv = "005", name = "Bao", age = 15 }
            };

            bool exit = false;
            while (!exit)
            {
                
                Console.WriteLine("=== MENU THUC HIEN NHIEM VU ===");
                Console.WriteLine("1. Them 1 sinh vien");
                Console.WriteLine("2. Hien thi danh sach sinh vien");
                Console.WriteLine("3. Tim danh sach hoc sinh co tuoi tu 15 - 18.");
                Console.WriteLine("4. Hien thi danh sach sinh vien bat dau bang chu A.");
                Console.WriteLine("5. Tinh tong tuoi hoc sinh");
                Console.WriteLine("6. Tim hoc sinh co so tuoi lon nhat.");
                Console.WriteLine("7. Sap xep hoc sinh co tuoi tang dan.");
                Console.WriteLine("0. Thoat!");
                Console.WriteLine();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent(studentList);
                        break;

                    case "2":
                        DisplayStudent(studentList);
                        break;

                    case "3":
                        DisplayStudentByAge(studentList, 15, 18);
                        break;

                    case "4":
                        DisplayStudentStartWithA(studentList);
                        break;

                    case "5":
                        DisplaySumStudent(studentList);
                        break;
                    
                    case "6":
                        DisplayOldestStudent(studentList);
                        break;

                    case "7":
                        SortedStudentByAge(studentList);
                        break;

                    case "0":
                        exit = true;
                        Console.WriteLine("Ket thuc chuong trinh!");
                        break;
                    default:
                        Console.WriteLine("Tuy chon khong hop le! Vui long chon lai.");
                        break;
                }
            }
        }
        // 1)
        static void AddStudent(List<DanhSachHS> studentList)
        {
            Console.WriteLine("=== NHAP THONG TIN SINH VIEN ===");
            DanhSachHS student = new DanhSachHS();
            student.Input();
            studentList.Add(student);
            Console.WriteLine("Them sinh vien thanh cong!");
            Console.WriteLine();
        }
        // 2)
        static void DisplayStudent(List<DanhSachHS> studentList)
        {
            Console.WriteLine("=== CHI TIET SINH VIEN ===");
            foreach (DanhSachHS student in studentList)
            {
                student.Output();
                
            }
            Console.WriteLine();
        }

        // 3)
        static void DisplayStudentByAge(List<DanhSachHS> studentList, int minAge, int maxAge)
        { 
            
            Console.WriteLine("=== CHI TIET SINH VIEN THUOC TUOI {0} DEN {1} ===", minAge, maxAge);
            var ByAgestudents = studentList.Where(s => s.age >= minAge && s.age <= maxAge);
            foreach (var Student in ByAgestudents)
            {
                Console.WriteLine($"MSSV : {Student.mssv} - Ten: {Student.name} - Tuoi: {Student.age}.");
            }
            Console.WriteLine();
            
        }


        // 4)
        static void DisplayStudentStartWithA(List<DanhSachHS> studentList)
        {
            Console.WriteLine("=== CHI TIET SINH VIEN BAT DAU BANG CHU A === ");
            var studentByA = studentList.Where(s => s.name.StartsWith("A", StringComparison.OrdinalIgnoreCase));
            foreach (var student in studentByA)
            {
                Console.WriteLine($"MSSV: {student.mssv} - Ten: {student.name} - Tuoi: {student.age}");
            }
            Console.WriteLine();
        }
        
        // 5)
        static void DisplaySumStudent(List<DanhSachHS> studentList)
        {
            Console.WriteLine("=== CHI TIET TONG SO TUOI SINH VIEN ===");
            var sumStudent = studentList.Sum(s => s.age);
            Console.WriteLine($"Tong so tuoi trong danh sach la: " + sumStudent.ToString() + "tuoi. ");

            Console.WriteLine();
        }

        // 6)

        static void DisplayOldestStudent (List<DanhSachHS> studentlist)
        {
            Console.WriteLine("=== CHI TIET SINH VIEN LON TUOI NHAT ===");
            var StudentByOldestAge = studentlist.OrderByDescending(s => s.age).FirstOrDefault();
            Console.WriteLine($"Sinh vien co tuoi lon nhat la: {StudentByOldestAge.name} - Tuoi: {StudentByOldestAge.age}");

            Console.WriteLine();
        }

        // 7)
        static void SortedStudentByAge (List<DanhSachHS> studentList)
        {
            Console.WriteLine("=== CHI TIET DANH SACH DA SAP XEP ===");
            var SortedByAge = studentList.OrderBy(s => s.age);
            foreach (var students in SortedByAge)
            {
                Console.WriteLine($"MSSV: {students.mssv} - Ten: {students.name} - Tuoi: {students.age}");
            }
            Console.WriteLine();
        }
    }
}

