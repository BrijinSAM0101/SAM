using System;

namespace Learn{


public struct Book{
    public int bookno;
    public string  bookname;

    public string author;

    public static void fun11(){
        System.Console.WriteLine("hai ,i am from struct");
    }
}
public class UK
{
    public static void Main(string[] args)
    {
        Book B1=new Book();
        B1.bookno=101;
        B1.bookname="C#";
        B1.author="sam";
        System.Console.WriteLine(B1.bookno);
        System.Console.WriteLine(B1.bookname);
        System.Console.WriteLine(B1.author);
   
        System.Console.WriteLine();

        Book B2=new Book();
        B2.bookno=102;
        B2.bookname="ASP.net";
        B2.author="naw";
        System.Console.WriteLine(B2.bookno);
        System.Console.WriteLine(B2.bookname);
        System.Console.WriteLine(B2.author);

        Book.fun11();
         
    }
}

}