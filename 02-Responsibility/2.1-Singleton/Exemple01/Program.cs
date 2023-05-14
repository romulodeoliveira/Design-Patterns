using System;

namespace Exemple01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetInstance();
            singleton.SomeMethod();

            // O mesmo objeto será retornado
            Singleton anotherSingleton = Singleton.GetInstance();
            anotherSingleton.SomeMethod();

            // Verificando se são o mesmo objeto
            bool isSameInstance = singleton == anotherSingleton;
            Console.WriteLine("Os dois objetos são a mesma instância? " + isSameInstance);
        }
    }
}