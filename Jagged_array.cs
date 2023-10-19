using System;

namespace Learn{


public class jagged_array
{
    public static void Main(string[] args)
    {
       string [] [] str=new string [5][];

       str[0]=new string[5];
       str[1]=new string[10];
       str[2]=new string[20];
       str[3]=new string[50];
       str[4]=new string[10];

       str[0][0]="pune";
       str[1][0]="delhi";
       str[2][0]="tamilnadu";
       str[3][0]="kerala";
       str[4][0]="hyderabad";

       for(int i=0;i<5;i++){
        System.Console.WriteLine(str[i][0]);
       }   

    }
}
}