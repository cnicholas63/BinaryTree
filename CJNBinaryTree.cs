/*
 * 20/10/14 Chris Nicholas 22489355
 * A Binary tree class that uses Generics and Delegates. Uses Node class for node objects
 * Tree puts values <= key to left
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class CJNBinaryTree<BaseType>
    {
        public delegate void Print(BaseType data);  // Delegate for printing node data (function pointer)
        public delegate int Compare(BaseType data1, BaseType data2); // Delegate for comparing nodes
        public Compare CompFunc;
        public Print PrintFunc;
        private Node<BaseType> tempNode;            // Temporary node used in methods
        public Node<BaseType> root;                 // Root node
        private int comparisonResult;               // Holds the result of comparison operations.
 

        public CJNBinaryTree(Compare comp, Print print)         // Construct new binary tree root
        {
            // root = new Node<BaseType>(data);        // Start by constructing a root node with data and null left and right links

            root = null;                            // No root yet, this is an empty rett
            CompFunc = comp;                        // Reference to comparison function
            PrintFunc = print;                      // Reference to print function

        }

        public Boolean AddNode(BaseType data) // Add a new node to the tree
        {
            if (root == null)
            {       // No root yet
                root = new Node<BaseType>(data); // Give root a node with some data
                Console.Write("Initialiseing Root: ");
                PrintFunc(root.data);

                return true;                     // Finished adding this node
            }
            
            Node<BaseType> startNode = root;  // Start searching for node location from root

            Node<BaseType> newNode = new Node<BaseType>(data); // Create a new node with the data in it

            int nodeLocation; // This will hold <=0 for left node, >=1 for right node

            startNode = FindNode(newNode, startNode, 0);  // Compare the nodes, when this comes back tempNode will be the parent for the new node
            // tempNode holds the parent of the new node

            if (comparisonResult < 1) { // The new node goes to the left
                startNode.left = newNode;    // Left link parent node to new node
                Console.WriteLine("Adding new node left");  ///////////////////////////////////Debug delete when finished
            }
            else // The new node goes to the right
            {
                startNode.right = newNode;   // Right link the  parent to new node
                Console.WriteLine("Adding new node right"); ///////////////////////////////////Debug delete when finished
            }

            newNode.parent = tempNode;  // Regardless of direction, link new node back to parent node

            return true;
        }



        /* 
         * Traverses the tree using recursion and custom compare method (CompFunc) to locate the target node.
         * requiredNode = the node being searched for, currentNode the node we are looking in currently
         * Returns  <0 target not found should go in left node
         *         ==0 Target located in thisNode
         *          >0 Target not found should go in right node
         */
        public Node<BaseType> FindNode(Node<BaseType> requiredNode, Node<BaseType> currentNode, int iteration) {
            

            PrintFunc(currentNode.data); // Print the data in the current node
            Console.WriteLine(iteration);
            
            comparisonResult = CompFunc(requiredNode.data, currentNode.data); // Compare the node data and store result of comparison

            if (comparisonResult < 1 && currentNode.left != null) // if the target node is less than or equal this node and there is a node to the left 
            {
                Console.WriteLine("Recurse Left"); ///////////////////////////////////Debug delete when finished
                currentNode = FindNode(requiredNode, currentNode.left, iteration + 1); // recurse into it
            }
            else if (comparisonResult >= 1 && currentNode.right != null)        // Target node goes to the right, is there a node there?
            {
                Console.WriteLine("Recurse Right"); ///////////////////////////////////Debug delete when finished
                currentNode = FindNode(requiredNode, currentNode.right, iteration + 1);   // Recurse into the right node
            }
            else // target node or parent of target node found
            {
                tempNode = currentNode; // Temp node points to the required node. If comparison result == 0 this is the node else it is the parent
            }

            return currentNode; // Return the comparison result 
        }

        public Node<BaseType> GetRootNode() // Returns the root node
        {
            return root;

        }

        public void PrintListAscending(Node<BaseType> node) // Prints the node content in ascending order of key
        {
            // If there is a left branch, go down it
            if (node.left != null) // Recurse down the left nodes
                PrintListAscending(node.left);

            PrintFunc(node.data); // Print this nodes contents

            // If there is a right branch, go down it
            if (node.right != null) // Recurse into right node
                PrintListAscending(node.right);

        }

        public void PrintListDescending(Node<BaseType> node) // Prints the node content in ascending order of key
        {
            // If there is a right branch, go down it
            if (node.right != null) // Recurse down the left nodes
                PrintListDescending(node.right);

            PrintFunc(node.data); // Print this nodes contents

            // If there is a left branch, go down it
            if (node.left != null) // Recurse into right node
                PrintListDescending(node.left);

        }









        public void printNode(Print print, Node<BaseType> node) { // Print node data using delegate
            print(node.data);
        }
    }
}
