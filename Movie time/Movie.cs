using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Movie_time
{
    public enum Movie
    {
        Drama,
        Horror,
        Romance,
        Comedy,
        Action

    }

    public abstract class Movie2
    {
        public abstract string Name { get; set; }
        
        public abstract string Catagory { get; set; }

        public double runTime { get; set; }

        public List <string> Scene { get; set; }

        public Movie2(string Name, string Catagory, int runTime,List<string> Scene)
        {
            this.Name = Name;
            this.Catagory = Catagory;
            this.runTime = runTime;
            this.Scene = Scene;
        }

        public static void output()
        {
            Console.WriteLine($"Name: {Name}, Catagory: {Catagory}, runtime:, { runTime}, Scene: {Scene}");
        }
        public void print(List<string> Scenes)
        {
            for(int i = 0; i < Scene.Count; i++)
            {
                Console.WriteLine(i + " " + Scenes[i]);
            }
        }
        public abstract


}
