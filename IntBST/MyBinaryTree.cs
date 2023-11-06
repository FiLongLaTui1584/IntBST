using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntBST
{
    internal class MyBinaryTree
    {
        private IntTNode root;
        public IntTNode Root
        {
            get { return root; }
            set { root = value; }
        }
        public MyBinaryTree()
        {
            root = null;
        }
        public bool Insert(int x)
        {
            if (root == null)
            {
                root = new IntTNode(x);
                return true;
            }
            return root.InsertData(x);
        }
        public void Input()
        {
            int x;
            do
            {
                Console.Write("Nhap vao gia tri (trung ket thuc): ");
                x = int.Parse(Console.ReadLine());
                if (Insert(x) == false)
                {
                    Console.Write("Gia tri da trung -> Ket thuc input");
                    break;
                }
            } while (true);
        }


        public void processNLR()
        {
            if (root == null)
                return;
            root.NLR();
            Console.WriteLine();
        }
        public void processLNR()
        {
            if (root == null)
                return;
            root.LRN();
            Console.WriteLine();
        }
        public void processLRN()
        {
            if (root == null)
                return;
            root.LRN();
            Console.WriteLine();
        }

        public int CountLeaf()
        {
            if (root == null)
                return 0;
            else
                return root.CountLeaf();
        }

        public int CountNodeTrong()
        {
            int count = 0;
            if (root == null)
                return 0;
            else
                return root.CountInt(ref count) - root.CountLeaf() - 1;
        }
    }
}
