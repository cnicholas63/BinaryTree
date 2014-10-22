/*
 * 20/10/14 C Nicholas 22489355
 * Node class definition for use with binary tree
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node<BaseType> // Base type for Generics type checking
    {
        public BaseType data;          // The data stored in the node;
        public Node<BaseType> parent;  // Pointer to parent node
        public Node<BaseType> left;    // Pointer to left node (if any)
        public Node<BaseType> right;   // Pointer to right node (if any)
        
        public Node(BaseType data) {    // Node Constructor
            this.data = data;           // Assign data
            parent = null;              // No parent node as yet (unless root when it will remain null)
            left = null;                // No left node as yet - only in constructor
            right = null;               // No right node as yet - only in constructor
        }   

        





    }
}
