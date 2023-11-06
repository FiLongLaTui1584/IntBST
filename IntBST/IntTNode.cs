using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IntBST
{
    internal class IntTNode
    {
        private int data;
        private IntTNode left;
        private IntTNode right;
        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public IntTNode Left
        {
            get { return left; }
            set { left = value; }
        }
        public IntTNode Right
        {
            get { return right; }
            set { right = value; }
        }
        public IntTNode(int x = 0)
        {
            data = x;
            left = null;
            right = null;
        }
        public bool InsertData(int x)
        {
            if (data == x) //Trùng giá trị
                return false;
            if (data > x) //Giá trị cần thêm nhỏ hơn -> chèn về trái
            {
                if (left == null)
                {
                    left = new IntTNode(x);
                    return true;
                }
                else
                    return left.InsertData(x);
            }
            else //Giá trị cần thêm lớn hơn -> chèn về phải
            {
                if (right == null)
                {
                    right = new IntTNode(x);
                    return true;
                }
                else
                    return right.InsertData(x);
            }
        }
        public void NLR()
        {
            Console.Write(Data + "; ");
            if (left != null)
                left.NLR();
            if (right != null)
                right.NLR();
        }
        public void LNR()
        {
            if (left != null)
                left.LNR();
            Console.Write(Data + "; ");
            if (right != null)
                right.LNR();
        }
        public void LRN()
        {
            if (left != null)
                left.LRN();
            if (right != null)
                right.LRN();
            Console.Write(Data + "; ");
        }
        public int CountLeaf()
        {
            if (left == null && right == null)
            {
                return 1;
            }
            int countL = 0, countR = 0;
            if (left != null)
                countL = left.CountLeaf();
            if (right != null)
                countR = right.CountLeaf();
            return countL + countR;
        }
        public int CountInt(ref int count)
        {
            count++;
            if (left != null) 
                left.CountInt(ref count);
            if (right != null)
                right.CountInt(ref count);
            return count;
        }
        public int CountNodeBac1()
        {
            int count = 0;
            if ((left == null && right != null) || (left != null && right == null)) 
            {
                count++;
            }
            count += CountNodeBac1(left) + CountNodeBac1(right);

            return count;
        }
    }
}
