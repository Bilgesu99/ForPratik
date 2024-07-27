using System;
using System.Diagnostics.CodeAnalysis;
class program
{
    static void Main(string[] args)

        //Soru 1
        for (int sayı = 0; sayı< 10; sayı++) //10'dan küçük olma şartını koştum. Büyük eşittir kullanmadım çünkü ilk değer 0 olduğundan 11 kere tekrar ediyordu.
        {
        Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim");
        }
}
        //Soru 2
        for (int a = 2; a < 20; a++)   //Pratikte 1 ile 20 arasındaki sayılar dendiği için 1 ve 20'yi dahil ettirmeden yazdırdım.
        {
        Console.WriteLine(a);
        }


        //Soru 3
        for (int a = 2; a < 20; a += 2)   //Pratikte 1 ile 20 arasındaki sayılar dendiği için 1 ve 20'yi dahil ettirmeden yazdırdım.
        {
        Console.WriteLine(a);
        }


        //Soru 4
        int deger = 0;  //burada herhangi bir sayı değeri atadım. 

        for (int b = 50; b <= 150; b++)
         {
     deger += b; //yukarıda 0 olarak bir değer atamıştık. b değişkeni sayı aldıkça bunu deger değişkenine ekle dedim. Böylece for dçngüsünden çıkan her sayı 0'a eklenecek
    Console.WriteLine("50 ile 150 arasındaki sayıların toplamı" + deger);
        }

        // Soru 5
        int cift = 0;
        int tek = 0;

        for(int sayı =1; sayı<=120; sayı++)
        {
            if(sayı %2 == 0)
            {
                cift += sayı;
            }
            else
            {
                tek += sayı;
            }
        }
        Console.WriteLine("çift sayıların toplamı" + cift);
        Console.WriteLine("Tek sayıların toplamı" + tek);

    }
}

        