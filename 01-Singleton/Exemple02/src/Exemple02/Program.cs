using System;

// https://learn.microsoft.com/pt-br/dotnet/core/extensions/logging?tabs=command-line

namespace Exemple02.src
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Singleton singleton = Singleton.Instance;
            singleton.DoSomething();
        }
    }
}