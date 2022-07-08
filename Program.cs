using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atinea_OI_XV_PLA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wys = new List<int>();
            string line;
            int n = Int32.Parse(Console.ReadLine());
            while (!String.IsNullOrEmpty(line=Console.ReadLine())) 
            {
                string[] a = line.Split();
                wys.Add(Int32.Parse(a[1]));
            }
            
            List<int> s = new List<int>();
            int p=0;
            s.Add(0);           // zainicjowanie "pustej" listy stosu
            

            for(int i = 0; i < n; i++)
            {
                while (s.Count!=0 & s[0]>wys[i])
                {
                    s.RemoveAt(0);
                }
                if(s.Count==0 ^ s[0]<wys[i])
                {
                    s.Insert(0,wys[i]);
                    p++;
                }
            }

            Console.WriteLine(p); 
        }
    }
}
