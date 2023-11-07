using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1._6
{
    internal interface IThinking
    {
        void thinking_behavior();
    }
    internal interface IIntelligent
    {
        void intelligent_behavior();
    }
    internal interface IAbility : IIntelligent, IThinking { }

    class Human : Mamal, IAbility
    {
        public Human() => Console.WriteLine("I'am a human");
        void IIntelligent.intelligent_behavior() => Console.WriteLine("Brain is so bravo");
        void IThinking.thinking_behavior() => Console.WriteLine("Brain can think a lot!");
    }

    internal class Mamal
    {
        public string characteristics;
    }

    internal class Whale : Mamal
    {
        public Whale() => Console.WriteLine("My name is whale\n\r");
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Mamal mamal = new Mamal();
            Whale whale = new Whale();

            Human human = new Human();
            IThinking think = human;
            think.thinking_behavior();
            IIntelligent intell = human;
            intell.intelligent_behavior();

            Console.ReadLine();
        }
    }
}
