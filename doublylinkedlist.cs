using System;

class Node {
    public int data;
    public Node next;
    public Node prev;
}

class  LinkedList{
    public Node head;
    //construtor to create a empty LinkedList 
    public LinkedList(){
        head=null;
    }

     //display the content of the list
     public void printList(){
        
        Node temp =new Node();
        temp =this.head;

        if(temp!=null){
            System.Console.WriteLine("this list contains:");
            while(temp!=null){
                System.Console.WriteLine(temp.data + " ");
                temp =temp.next;
            }
            System.Console.WriteLine();
        }else{
            System.Console.WriteLine("This list is empty");
        }
     }
           static void Main(string[] args){

             LinkedList list = new LinkedList();

             Node first =new Node();
             first.data=10;
             first.next=null;
             first.prev=null;

             list.head=first;

             Node second =new Node();
             second.data=10;
             second.next=null;
             second.prev=first;
             first.next=second;
              
             Node third =new Node();
             third.data=10;
             third.next=null;
             third.prev=first;
             second.next=third;

             

             list.printList();

             



        }
     }
