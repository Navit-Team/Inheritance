using System;

namespace PolyMorphysm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] humanTrafficking = {new Person("liran", "bratt", 16, 232323), new Worker("19:00", "CS", "working", "rich af", "joe", "biden", 79, 23232)}; 
            for (int i = 0; i < humanTrafficking.Length; i++)
                Console.WriteLine(humanTrafficking[i].ToString());
        }
    }
}
