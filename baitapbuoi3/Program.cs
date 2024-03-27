using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapbuoi3
{
    internal class Program
    {
            static void nhapmang(  out int[]  mangvao)
            {
                Console.WriteLine("nhap so phan tu cua mang: ");
                string n = Console.ReadLine();
                int Kiemtra;
                bool isNumeric = int.TryParse(n, out Kiemtra);
                while (isNumeric == false)
                {
                    Console.WriteLine("ban nhap khong phai so! xin moi nhap lai:");
                    n = Console.ReadLine();
                    isNumeric = int.TryParse(n, out Kiemtra);
                }
                mangvao =new int[Kiemtra];
                if (Kiemtra > 0)
                {
                    for (int i = 0; i < Kiemtra; i++)
                    {
                        Console.WriteLine("nhap phan tu thu " + i + " :");
                        string kti = Console.ReadLine();
                        int Ktrasoi;
                        bool ilaso = int.TryParse(kti, out Ktrasoi);
                        while (ilaso == false)
                        {
                            Console.WriteLine("ban nhap khong phai so! xin moi nhap lai:");
                            n = Console.ReadLine();
                            isNumeric = int.TryParse(n, out Ktrasoi);
                            if ((Ktrasoi > -2147483648) && (Ktrasoi < 2147483647))
                            {
                                Console.WriteLine("ban nhap so khong trong khoang int, xin moi nhap lai.");
                                ilaso = false;
                            }
                        }
                        mangvao[i] = Ktrasoi;
                    }
                    Console.WriteLine("mang ban vua nhap la: ");
                    foreach ( int i in mangvao) { Console.Write(i+" "); }
                    Console.WriteLine();
                }
                else { Console.WriteLine("ban nhap so qua lon hoac nho hon khong"); }

            }
            static void inmagchanle(int[] mangvao )
            {
                Console.WriteLine("mang le:");
                foreach (int i in mangvao)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine("\nmang chan:");
                foreach (int i in mangvao)
                {
                    if (i % 2 == 0)
                    {
                    Console.Write(i + " ");
                    }
                }   
                Console.WriteLine();
            }
            static void sapxepmang(int[] mangvao)
            {
                var mangxeptang = mangvao.OrderBy(x => x);
                Console.WriteLine("mang sap xep tang: ");
                foreach (int i in mangxeptang)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                var mangxepgiam = mangvao.OrderByDescending(x => x);
                Console.WriteLine("mang sap xep giam: ");
                foreach (int i in mangxepgiam)
                {
                    Console.Write(i + " ");
                }
            }
            static void tongsochanle(int[] mangvao)
            {
            int tongchan=0, tongle=0;
            foreach (int i in mangvao)
            {
                if (i % 2 != 0)
                {
                    tongle = tongle + i; 
                }
            }
            Console.WriteLine("\ntong so le la: "+tongle);
            foreach (int i in mangvao)
            {
                if (i % 2 == 0)
                {
                    tongchan = tongchan + i;
                }
            }
            Console.WriteLine("tong so chan la: "+tongchan);
            }
            static void soamstrong(int[] mangvao)
            {
            Console.WriteLine("bat dau kiem tra so amstrong!");
                foreach (var i in mangvao )
                {
                    int luythua = 0, kiemtra = i, chuso = 0,tongchuso=0;
                    while (kiemtra != 0)
                    {
                        kiemtra=kiemtra/10;
                        luythua++;
                    }
                    kiemtra = i;
                    while (kiemtra != 0)
                    {
                        chuso = kiemtra % 10;
                        tongchuso += (int)Math.Pow(chuso, luythua);
                        kiemtra /= 10;
                    }
                    if (tongchuso == i) { Console.WriteLine("so " + i + " trong mang la so amstrong"); }
                    else{ Console.WriteLine("so " +i + " trong mang khong la so amstrong"); }
                }
            }
            static void songuyento(int[] mangvao)
            {
                int tongsongto = 0;
                foreach (var i in mangvao)
                {
                    int dem = 0;
                    for (int j = 1; j <= i / 2; j++)
                    {
                        if (i % j == 0) { dem++; }
                    }
                    if (dem == 1) { tongsongto = tongsongto + i; }
                }
                Console.WriteLine("tong cac so nguyen to trong mang la: " + tongsongto);
            }
            static void tongsochanletc(int[] mangvao,out int tongchan, out int tongle)
            {
            tongchan = 0;tongle = 0;
                foreach (int i in mangvao)
                {
                    if (i % 2 != 0)
                    {
                        tongle = tongle + i;
                    }
                }
                Console.WriteLine("\ntong so le la: " + tongle);
                foreach (int i in mangvao)
                {
                    if (i % 2 == 0)
                    {
                         tongchan = tongchan + i;
                    }
                }
                Console.WriteLine("tong so chan la: " + tongchan);
            }
            static void Main(string[] args)
            {
                int[] mangso = {};
                nhapmang(out 
                    mangso);
                int tongchanra, tonglera;
                Console.WriteLine("xin moi nhap lua chon cua ban: tu 1-6.\n1.la in ra mang chan va mang le tu mang ban vua nhap.\n2.la in ra sap xep tang dan va giam dan cua mang ban vua nhap." +
                    "\n3.tinh tong so chan va tong so le trong mang ban vua nhap.\n4.kiem tra cac so trong mang co la so amstrong hay khong." +
                    "\n5.tinh tong cac so nguyen to co trong mang. \n6.tinh tong cac so chan va le bang tham chieu.");
                string n = Console.ReadLine();
                int Kiemtra;
                bool isNumeric = int.TryParse(n, out Kiemtra);
                if (Kiemtra < 1 || Kiemtra > 6)
                {
                    Console.WriteLine("ban phai nhap so trong menu lua chon!");
                    isNumeric = false;
                }
                while (isNumeric == false)
                {
                    Console.WriteLine("ban nhap khong phai so! xin moi nhap lai:");
                    n = Console.ReadLine();
                    isNumeric = int.TryParse(n, out Kiemtra);
                    if(Kiemtra<1||Kiemtra>6)
                    {
                        Console.WriteLine("ban phai nhap so trong menu lua chon!");
                        isNumeric = false;
                    }
                }
                switch (Kiemtra)
                {
                case 1:
                    inmagchanle(mangso);
                    break;
                case 2:
                    sapxepmang(mangso);
                    break;
                case 3:
                    tongsochanle(mangso);
                    break;
                case 4:
                    soamstrong(mangso);
                    break;
                case 5:
                    songuyento(mangso);
                    break;
                case 6:
                    tongsochanletc(mangso, out tongchanra, out tonglera);
                    Console.WriteLine("tham chieu ra tong chan ra la " + tongchanra + "\ntham chieu ra tong le ra :" + tonglera);
                    break;
                default:
                    break;
                }
            Console.ReadKey();
            }
        }
}
