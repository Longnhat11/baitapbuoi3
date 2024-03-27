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
            static void Main(string[] args)
            {
                int[] mangso = {};
                nhapmang(out mangso);
                inmagchanle(mangso);
                sapxepmang(mangso);
                tongsochanle(mangso);
                soamstrong(mangso);
                Console.ReadKey();
            }
        }
}
