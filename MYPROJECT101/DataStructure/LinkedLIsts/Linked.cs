﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECT101.DataStructure.LinkedLIsts
{
    public class Linked
    {
        public Node? First { get; set; }


        public void InsertFirst(int data)
        {
            //Creating a new node
            Node newNode = new Node();
            //Assigning the data to new node
            newNode.Data = data;
            //put old node in next
            newNode.Next = First;
            //Make first the new node
            First = newNode;
        }
        public Node DeleteFirst()
        {
            //temporary variable 
            Node temp = First;
            //making next node the first, it deletes the first node
            First = First.Next;
           
            return temp;
        }


        public void InsertLast(int data)
        {
            Node current = First;
            while (current.Next != null)
            {
                current = current.Next;
            }
            Node newnode = new Node();
            newnode.Data = data;
            current.Next = newnode;
        }

        public void DisplayList()
        {
            Console.WriteLine("Iterating through the list");
            Node current = First;
            while (current != null)
            {
                //why does it have to be current.displaynode?
                current.DisplayNode();
                //current.next inside a while loop means you are iterating
                current = current.Next;
            }
            
        }


    }
}
