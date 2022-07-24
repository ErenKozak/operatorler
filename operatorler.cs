using System;

namespace console_programlama
{
    class pogram
    {
        static void Main(string[] args)
        {
            // atama ve işlemli atama 
            int x = 3;
            int y = 3;

            Console.WriteLine(y);
            y= y+2;
            Console.WriteLine(y);
            y+=2;

            // MANTIKSAL OPERATÖRLER
            
            // || , && , ! 

            bool isSucces = true;
            bool isComplated = false;

            if(isSucces && isComplated)
            Console.WriteLine("perfect");

            if(isSucces || isComplated)
            Console.WriteLine("great");

            if(isSucces && !isComplated)
            Console.WriteLine("fine");

            // ilişkisel operatörler
            // < , > , <= , >= , == , =!

            int a = 3;
            int b = 4;

            bool sonuc = a<b;
            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);


            // aritmetik operatörler

            // / , * , + , -

            int sayi1=10;
            int sayi2=5;

            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);

            int sonuc4 = sayi1*sayi2;
            Console.WriteLine(sonuc4);

            int sonuc2 = sayi1+sayi2;
            Console.WriteLine(sonuc2);

            int sonuc3 = sayi1-sayi2;
            Console.WriteLine(sonuc3);

            int sonuc5 = sayi1%sayi2;
            Console.WriteLine(sonuc5);
            












































            
        }
    }
}