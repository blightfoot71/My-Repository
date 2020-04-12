using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTree
{
    public class AVLTree
    {
        private class AVLNode
        {
            public int value;
            public int height;
            public AVLNode leftChild;
            public AVLNode rightChild;

            public AVLNode(int value)
            {
                this.value = value;
            }

            public override string ToString()
            {
                return "Value=" + this.value;
            }
        }

        private AVLNode root;

        public void Insert(int value)
        {
            root = Insert(root, value);
        }

        private AVLNode Insert(AVLNode root, int value)
        {
            if (root == null)
            {
                return new AVLNode(value);
            }

            if (value < root.value)
                root.leftChild = Insert(root.leftChild, value);
            else
                root.rightChild = Insert(root.rightChild, value);

            SetHeight(root);

            return Balance(root);
        }

        private AVLNode Balance(AVLNode root)
        {
            if (IsLeftHeavy(root))
            {
                if (BalanceFactor(root.leftChild) < 0)
                    root.leftChild = LeftRotate(root.leftChild);
                return RightRotate(root);
                
            }
            else if (IsRightHeavy(root))
            {
                if (BalanceFactor(root.rightChild) > 0)
                    root.rightChild = RightRotate(root.rightChild);
                return LeftRotate(root);
            }

            return root;
        }

        private AVLNode LeftRotate(AVLNode root)
        {
            var newRoot = root.rightChild;

            root.rightChild = newRoot.leftChild;
            newRoot.leftChild = root;

            SetHeight(root);
            SetHeight(newRoot);

            return newRoot;
        }

        private AVLNode RightRotate(AVLNode root)
        {
            var newRoot = root.leftChild;

            root.leftChild = newRoot.rightChild;
            newRoot.rightChild = root;

            SetHeight(root);
            SetHeight(newRoot);

            return newRoot;
        }

        private void SetHeight(AVLNode node)
        {
            node.height = Math.Max(height(node.leftChild), height(node.rightChild)) + 1;
        }

        private bool IsLeftHeavy(AVLNode node)
        {
            return BalanceFactor(node) > 1;
        }

        private bool IsRightHeavy(AVLNode node)
        {
            return BalanceFactor(node) < -1;
        }

        private int BalanceFactor(AVLNode node)
        {
            return (node == null) ? 0 : height(node.leftChild) - height(node.rightChild);
        }

        private int height(AVLNode node)
        {
            //if (node == null)
            //    return -1;

            //return node.height;

            return (node == null) ? -1 : node.height;
        }
    }
}
