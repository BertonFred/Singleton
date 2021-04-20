using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SingletonThree
    {
        public static SingletonThree Instance()
        {
            if (m_Instance == null)
            {
                lock (objLock)
                {
                    if (m_Instance == null)
                    {
                        m_Count++;
                        Console.WriteLine($"Création de l'instance Count={m_Count}");
                        m_Instance = new SingletonThree();
                        Task.Delay(1000).Wait();
                    }
                }
            }

            return m_Instance;
        }
        private static readonly object objLock = new object();
        private static SingletonThree m_Instance;
        private static int m_Count;

        private SingletonThree()
        {
        }

        public void SomeMethod(string Msg)
        {
            Console.WriteLine($"{Msg}");
        }
    }
}
