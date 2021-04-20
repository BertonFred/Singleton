using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SingletonTwo
    {
        public static SingletonTwo Instance()
        {
            lock (objLock)
            {
                if (m_Instance == null)
                {
                    m_Count++;
                    Console.WriteLine($"Création de l'instance Count={m_Count}");
                    m_Instance = new SingletonTwo();
                    Task.Delay(1000).Wait();
                }
                return m_Instance;
            }
        }
        private static readonly object objLock = new object();
        private static SingletonTwo m_Instance;
        private static int m_Count;

        private SingletonTwo()
        {
        }

        public void SomeMethod(string Msg)
        {
            Console.WriteLine($"{Msg}");
        }
    }
}
