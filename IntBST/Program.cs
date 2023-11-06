using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntBST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyBinaryTree tree = new MyBinaryTree();
            int x, choice;
            bool ini = false;
            do
            {
                Console.Clear();
                Console.Write("1. Khoi tao cay\n2. Them lien tuc vao cay\n3. Them 1 gia tri vao cay\n4. Xuat ket qua duyet NLR\n5. Xuat ket qua duyet LNR\n6. Xuat ket qua duyet LRN\n7. Tra ve so luong node la trong cay\n8. Tra ve so luong node trong (khong phai la/goc)\n9. Thoat\nBan chon: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ini = true;
                        Console.Write("Khoi tao cay thanh cong");
                        break;
                    case 2:
                        if (ini)
                        {
                            tree.Input();
                        }
                        else
                            Console.WriteLine("Vui long khoi tao cay");
                        break;
                    case 3:
                        if (ini)
                        {
                            Console.Write("Nhap gia tri can them vao cay BST: ");
                            x = int.Parse(Console.ReadLine());
                            if (tree.Insert(x))
                            {
                                Console.WriteLine($"Them {x} vao cay BST thanh cong");
                            }
                            else
                            {
                                Console.WriteLine($"Them {x} vao cay BST khong thanh cong");
                            }
                        }
                        else
                            Console.WriteLine("Vui long khoi tao cay");
                        break;
                    case 4:
                        if (ini)
                        {
                            tree.processNLR();
                        }
                        else
                            Console.WriteLine("Vui long khoi tao cay");
                        break;
                    case 5:
                        if (ini)
                        {
                            tree.processLNR();
                        }
                        else
                            Console.WriteLine("Vui long khoi tao cay");
                        break;
                    case 6:
                        if (ini)
                        {
                            tree.processLRN();
                        }
                        else
                            Console.WriteLine("Vui long khoi tao cay");
                        break;
                    case 7:
                        if (ini)
                        {
                            Console.WriteLine($"So luong node la trong cay la: {tree.CountLeaf()}");
                        }
                        else
                            Console.WriteLine("Vui long khoi tao cay");
                        break;
                    case 8:
                        if (ini)
                        {
                            Console.WriteLine($"So luong node trong la: {tree.CountNodeTrong()}");
                        }
                        else
                            Console.WriteLine("Vui long khoi tao cay");
                        break;
                    default:
                        Console.WriteLine("Ket thuc");
                        return;
                }
                Console.ReadLine();
            }
            while (true);
        }
    }
}
