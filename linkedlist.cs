using System;

using System.Collections.Generic;

class Node {
    public int data;
    public Node next;
}
class  LinkedList{

   public Node head;

   public  LinkedList(){
    head=null;
   }

    public static void Main(string[] args){


     //create a empty LinkedList       
    LinkedList ll=new LinkedList();
 
    //Add First node .
    Node first=new Node();
    first.data=432;
    first.next=null;
   // linking with head node 
    ll.head=first;

   //Add second node 
    Node second=new Node();
    second.data=432;
    second.next=null;
    // linking with second node 
    first.next=second;



    //Add with Third node 
    Node third=new Node();
    third.data=432;
    third.next=null;
    // linking with third node 
    second.next=third;

    //Add with fourth node 
    Node fourth=new Node();
    fourth.data=432;
    fourth.next=null;
    // linking with third node 
    third.next=fourth;

   ll.PrintList();
    }
public void PrintList(){

        Node temp=new Node();
        
        temp=this.head;
        
        if(temp!=null){
         
             System.Console.WriteLine("this list conatines :");
            
            while(temp!=null){
         
                System.Console.WriteLine(temp.data+" ");
                temp=temp.next;

            }
            System.Console.WriteLine();
        }
    }
}