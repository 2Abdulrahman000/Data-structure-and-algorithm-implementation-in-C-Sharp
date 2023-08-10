using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Binarytree
    {
        public Node root;
        public void isertion(int key)                                                                   //INSERTION
        {
            Node node=new Node(key);
            if(root==null)root=node;
            else{
            Node current=root;
            Node parent=root;
            while (true){
            parent =current;
            if (key>current.data)
            {
            current=current.right;
                if(current==null){parent.right=node;  break;}
            }
            else
            {
            current=current.left;
                if(current==null){parent.left=node; break; }
            }
            }//end of while
            }//end of first else
        }//end of insertion function///////////////////////////////

        public string search(int key) {                                                                    //SEARCH 
            Node current = root;
            while (current.data != key) {
                if (current.data > key) current = current.left;
                else current = current.right;
                if (current == null) return "not found";
            }
            return "found";
        }//end of search function///////////////////////////////////

        public int getmax() {                                                                              //GET MAX
            Node current = root;
            while (!(current.right == null)) current = current.right;
            return current.data;
        }//end of getmax///////////////////////////////////////////                                  

        public int getmini() {                                                                             //GET MINI
            Node current = root;
            while (!(current.left == null)) current = current.left;
            return current.data;
        }//end of getmini///////////////////////////////////////////                                         
                        	
        public void inorder(Node node) {                                                                   //INORDER
            if (node != null)
            {
                inorder(node.left);
                Console.WriteLine(">>" + node.data);
                inorder(node.right);
            }
        }//end of inorder function////////////////////////////////////

        public void preorder(Node node) {                                                                  //PREORDER
           
            if (node != null) 
            {
                Console.WriteLine(">>"+node.data);
                postorder(node.left);
                postorder(node.right);
            }
        }//end of preorder function/////////////////////////////////////////////

        public void postorder(Node node) {                                                                 //POSTORDER
            if (node != null)
            {
                postorder(node.left);
                postorder(node.right);
                Console.WriteLine(">>"+node.data);
            }
        }//end of postorder function///////////////////////////////////////

        class Node                                                                                             //تكوين الشجرة
        {
            // TREEتكوين ال
           public int data;
           public Node right;
           public Node left;
           public Node(int data){this.data=data;}
        }
}
}

