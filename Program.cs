// See https://aka.ms/new-console-template for more information
using System;

namespace RefactoringGuru.DesignPatterns.Singleton.Conceptual.NonThreadSafe
{

    public sealed class Singleton
    {

        private Singleton() { }

     
        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public void someBusinessLogic()
        {
            // ...
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton trabaja correctamente, variables contienen misamas isntncias");
            }
            else
            {
                Console.WriteLine("Singleton fallo, variables contienen diferente instancias.");
            }
        }
    }
}

