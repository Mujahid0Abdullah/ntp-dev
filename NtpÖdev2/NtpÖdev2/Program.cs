using System;

namespace NtpÖdev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************Uygulama 1:******************* ");
            Console.WriteLine(48/6/4);
            Console.WriteLine(24/3*2);
            Console.WriteLine(Math.Pow(2,2));
            Console.WriteLine((7+4)*2-1+8/2);
            Console.WriteLine((5-1)*2-1+Math.Pow(7,2)+"\n");
            //OPeratör önceliği : paranters içinde->uslar->çarpma ve bölme -> toplama ve çıkarma




            Console.WriteLine("**************Uygulama 2:******************* ");
            int x, y, z;
            x = 20;
            y = 13;
            z = 42;

            if(23==55 && 76>45 && 5 < 12)
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");

            if (23>=23&& 45!=18)
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");

            if (x>y && z==y && z < x)
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");

            if (z>x&& y<x)
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");

            if (x != z|| y<=z)
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");




            Console.WriteLine("**************Uygulama 3:*******************");
            Console.WriteLine("birinci sayi girin:");
            int A =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayi girin:");
            int B = Convert.ToInt32(Console.ReadLine());
         
          
            if (A%B==0)
            {
                 
                Console.WriteLine("int: "+(A/B));
            }else 
            {
                
                Console.WriteLine("double: " +(Convert.ToDouble(A)/ Convert.ToDouble(B)));
            }


            Console.WriteLine("**************Uygulama 4:*******************");
            
            Console.Write("gg.aa.yyyy Fomatında bir tarih giriniz : ");
            String str = Console.ReadLine().Replace(".","/");
            try
            {
                DateTime Tarih = Convert.ToDateTime(str);
                Console.WriteLine("ay: " + Tarih.ToString("MMMM"));
            }
            catch(System.FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            



            Console.WriteLine("**************Uygulama 5:*******************");

            int a, b, c;

            double d, x1, x2;

            Console.Write("a değeri giriniz: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b değeri giriniz: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c değeri giriniz: ");
            c = Convert.ToInt32(Console.ReadLine());

            d =b*b-4*a*c;
            if (d==0)
            {
                Console.Write("iki kökler birbirine eşittir\n");
                x1 =-b/(2.0*a);
                x2 = x1;
                Console.WriteLine("ilk kök X1="+ x1);
                Console.WriteLine("ikinci kök X2="+ x2);
            }
            else if (d > 0)
            {
                Console.WriteLine("");

                x1 = (-b+Math.Sqrt(d))/(2*a);
                x2 = (-b-Math.Sqrt(d))/(2*a);

                Console.WriteLine("ilk kök X1=" + x1);
                Console.WriteLine("ikinci kök X2=" + x2);
            }
            else
                Console.WriteLine("Çözüm YOK.\n");

            Console.WriteLine("**************Uygulama 5:*******************");
            double Derece = Convert.ToDouble(Console.ReadLine());
            double Radyan = (Math.PI/180) * Derece;
            Console.WriteLine("Radyan="+Radyan);





        }
    }
}
