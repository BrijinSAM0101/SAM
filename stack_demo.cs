using System;

using System.Collections;

class  myclass123{
    static void Main(string[] args){

        Stack s1=new Stack();
        s1.Push(10);
        s1.Push(40);
        s1.Push(50);
        s1.Push(60);
        s1.Push(80);
        System.Console.WriteLine("List of item in stack:");

        foreach(int i in s1){
            Console.WriteLine(i);
        }

        s1.Pop();

        System.Console.WriteLine("List of item after pop s:");

        foreach(int i in s1){
            Console.WriteLine(i);
        }
     
     System.Console.WriteLine("count of stack :"+s1.Count);

     //s1.CleaR();
    }
}