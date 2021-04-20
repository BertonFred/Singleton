using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            #region zero
            // echoue a la compilation car le constructeur est privée
            // SingletonOne uneInstance = new SingletonOne();
            #endregion

            #region un
            // pas de thread c'est bon
            //SingletonOne.Instance().SomeMethod("Premier appel");
            //SingletonOne.Instance().SomeMethod("Deuxieme appel");
            #endregion

            #region deux
            // avec des thread c'est plus bon
            //Task t1 = Task.Run(() =>
            //{
            //    SingletonOne.Instance().SomeMethod("Premier appel");
            //});

            //Task t2 = Task.Run(() =>
            //{
            //    SingletonOne.Instance().SomeMethod("Deuxieme appel");
            //});

            //Task.WaitAll(new Task[]{t1,t2});
            #endregion

            #region trois
            // avec des thread c'est plus bon
            Task t1 = Task.Run(() =>
            {
                SingletonTwo.Instance().SomeMethod("Premier appel");
            });

            Task t2 = Task.Run(() =>
            {
                SingletonTwo.Instance().SomeMethod("Deuxieme appel");
            });

            Task.WaitAll(new Task[] { t1, t2 });
            #endregion

            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
