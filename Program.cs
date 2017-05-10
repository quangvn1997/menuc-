using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace menu
{
    class User
    {
        public string name;
        public string password;
    }

    class Program
    {

        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            int x = 0;
            do
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Lua chon.");
                Console.WriteLine("1. them danh user");
                Console.WriteLine("2. in danh sach user");
                Console.WriteLine("3. thoat");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Nhap lua chon cua ban: ");
                x = Convert.ToInt32(Console.ReadLine());
                
                switch (x)
                {
                    case 1:
                        Console.WriteLine("nhap so nguoi ban muon them");
                        int a = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= a; i++)
                        {
                            User u = new User();
                            Console.WriteLine("nhap ten nguoi {0}", i);
                            u.name = Console.ReadLine();
                            Console.WriteLine("nhap password nguoi {0}", i);
                            u.password = Console.ReadLine();
                            list.Add(u);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Danh sach");
                        Console.WriteLine("------------------------------------");
                        foreach(User u in list){
                            Console.WriteLine(u.name);
                            Console.WriteLine("_________________");
                            Console.WriteLine(u.password);
                            Console.WriteLine("_________________");
                        }
                        Console.WriteLine("------------------------------------");
                        break;
                    case 3:
                        Console.WriteLine("ket thuc chuong trinh");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("vui long chon trong 1,2,3");
                        break;
                }

            }
            while (x != 3);
        }
    }
}
