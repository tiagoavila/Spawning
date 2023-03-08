using Game.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using SFML.System;

namespace Game.GeneticAlgorithm
{
    public class Neighbour
    {
        private static Random random = new Random();

        public List<int> Sequence { get; set; }

        public Neighbour(List<int> sequence)
        {
            this.Sequence = sequence;
        }

        public double GetFitness()
        {
            double totalDistance = 0.0;

            for (int i = 1; i < Sequence.Count; i++)
            {
                Vector2f fromTown = TownHelper.TownPositions[Sequence[i - 1]];
                Vector2f toTown = TownHelper.TownPositions[Sequence[i]];

                float x = toTown.X - fromTown.X;
                float y = toTown.Y - fromTown.Y;

                double d = Math.Sqrt(x * x + y * y);

                totalDistance += d;
            }

            return totalDistance;
        }
    }
}
