using System;

using System.Collections.Generic;

class LD{
    public static void Main(String[] args){

        List<int>  ld=new List<int>();
        ld.Add(41);
        ld.Add(223);
        ld.Add(33);
        ld.Add(56);
        ld.Add(41);
        ld.Add(23);
        ld.Add(6);
         
         ld.Sort();
         System.Console.WriteLine("lsit items are :");

         foreach(int i in ld){
            System.Console.WriteLine(i);
         }

         System.Console.WriteLine("after remove funtion :");

         ld.Remove(33);

          foreach(int i in ld){
            System.Console.WriteLine(i);
         }
    }
}