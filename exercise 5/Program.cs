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

    }
}
