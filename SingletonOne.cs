using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SingletonOne
    {
        public static SingletonOne Instance()
        {
            if (m_Instance == null)
            {
                m_Count++;
                Console.WriteLine($"Création de l'instance Count={m_Count}");
                m_Instance = new SingletonOne();
                Task.Delay(1000).Wait();
            }

            return m_Instance;
        }
        private static SingletonOne m_Instance;
        private static int m_Count;

        private SingletonOne()
        {
        }

        public void SomeMethod(string Msg) 
        {
            Console.WriteLine($"{Msg}");
        }
    }
}
