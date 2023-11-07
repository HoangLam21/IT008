using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6
{
    interface IThinking
    {
        void thinking_behavior();
    }
    interface IIntelligent
    {
        void intelligent_behavior();
    }
    interface IAbility : IThinking, IIntelligent { }
    public class Mamal
    {
        public string characteristics { get; set; }
        public Mamal(string characteristics)
        {
            this.characteristics = characteristics;
        }
    }
    public class Whale : Mamal
    {
        public Whale(string characteristics) : base(characteristics) { }
    }
    public class Human : Mamal, IAbility
    {
        public Human(string characteristics) : base(characteristics) { }
        public void thinking_behavior()
        {
            Console.WriteLine("Thinking like a human. Human thoughts, feelings, and behaviours are rooted in the brain");
        }
        public void intelligent_behavior()
        {
            Console.WriteLine("Behaving intelligent. With intelligence, humans can learn, form concepts, understand, apply logic and reason,...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Whale whale = new Whale("One of the largest animals");
            Human human = new Human("The highest form of animals");

            try
            {
                if (whale is IThinking)
                {
                    ((IThinking)whale).thinking_behavior();
                }
                else
                {
                    Console.WriteLine("Whale does not support thinking behavior.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            try
            {
                if (whale is IIntelligent)
                {
                    ((IIntelligent)whale).intelligent_behavior();
                }
                else
                {
                    Console.WriteLine("Whale does not support intelligent behavior.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.WriteLine();
            human.thinking_behavior();
            human.intelligent_behavior();

            Console.ReadLine();
        }
    }
}
