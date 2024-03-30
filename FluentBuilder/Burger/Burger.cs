using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder.Burger
{
    public class Burger
    {
        public List<Cutlet> Cutlet { get; set; } = new List<Cutlet>();
        public List<Cheese> Cheese { get; set; } = new List<Cheese>();
        public List<Salat> Salat { get; set; } = new List<Salat>();
        public List<Bun> Bun { get; set; } = new List<Bun>();

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Burger ingridients:\n")
                .Append("\nCutlets:\n");

            foreach(var cutlet in Cutlet)
            {
                stringBuilder.Append(cutlet.Name + "\n");
            }

            stringBuilder.Append("\nCheese:\n");
            foreach(var cheese in Cheese)
            {
                stringBuilder.Append(cheese.Name + "\n");
            }

            stringBuilder.Append("\nSalat:\n");
            foreach (var salat in Salat)
            {
                stringBuilder.Append(salat.Name + "\n");
            }

            stringBuilder.Append("\nBuns:\n");
            foreach (var bun in Bun)
            {
                stringBuilder.Append(bun.Name + "\n");
            }

            return stringBuilder.ToString();
        }
    }
}
