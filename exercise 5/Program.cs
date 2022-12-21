using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_5
{
    class Node
    {
       public string nama;
       public Node next;

    }
    class Queue
    {
        Node alwan, ilham;
        public Queue()
        {
            alwan = null;
            ilham = null;
        }

        public void insert(string nm)
        {
            Console.Write("\nMasukkan nama Mahasiswa");
            nm = Console.ReadLine();
            Node nodeBaru = new Node();
            nodeBaru.nama = nm;
            nodeBaru.next = null;

            if (alwan == null)
            {
                alwan = nodeBaru;
                ilham = nodeBaru;
                return;
            }
            ilham.next = nodeBaru;
            ilham = nodeBaru;
        }
        
        public void delete()
        {
            if (alwan == null)
            {
                Console.WriteLine("Kosong!!!");
                return;
            }
            alwan = alwan.next;

            if (alwan == null)
                ilham = null;
        }

        public void display()
        {
            if (alwan == null)
            {
                Console.WriteLine("kososng");
                return ;
            }
            Node display;
        }
        static void Main(string[] args)
        {
            Queue q = new Queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.Write("Enter a number: ");
                                char nm = Convert.ToChar(System.Console.ReadLine());
                                Console.WriteLine();
                                q.insert(nm);
                            }
                            break;
                        case '2':
                            {
                                q.delete();
                            }
                            break;
                        case '3':
                            {
                                q.display();
                            }
                            break;
             
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }
    }
}
