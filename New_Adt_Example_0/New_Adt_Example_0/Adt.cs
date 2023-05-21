using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Adt_Example_0
{
    class Adt
    {
        public int[] dq;
        public int rear1;
        public int rear2;
        public int max;

        public Adt(int size)
        {
            dq = new int[size];
            max = size;
            rear1 = -1;
            rear2 = max;
        }
        public bool isfull()
        {
            if ((rear1 + 1) == rear2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isempty(bool ch)
        {
            if (ch)
            {
                return (rear1 == -1);
            }
            else
            {
                return (rear2 == max);
            }
        }
        public void insert(int data)
        {
            if (isfull())
            {
                Console.WriteLine("New Adt Is Full !");
                return;
            }
            if (data >= 0)
            {
                dq[++rear1] = data;
            }
            else
            {
                dq[--rear2] = data;
            }
        }
        public int remove(bool ch)
        {
            if (isempty(ch))
            {
                Console.WriteLine("Queue Is Empty !");
                return -1;
            }
            int d;
            if (ch)
            {
                d = dq[0];
                Console.WriteLine($"{d} Is Deleted...");
                for (int i = 0; i <= rear1; i++)
                {
                    dq[i] = dq[i + 1];
                }
                rear1--;
            }
            else
            {
                d = dq[max - 1];
                Console.WriteLine($"{d} Is Deleted...");
                for (int i = max - 1; i >= rear2; i--)
                {
                    dq[i] = dq[i - 1];
                }
                rear2++;
            }
            return d;
        }
        public int length()
        {
            return ((rear1 + 1) + (max - rear2));
        }
        public void print()
        {
            for (int i = 0; i < max; i++)
            {
                if (dq[i] == 0)
                {
                    Console.Write(". ");
                }
                else
                {
                    Console.Write((dq[i] + " . "));
                }
            }
        }
    }
}
