﻿using Game.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Game.GeneticAlgorithm
{
    public class World
    {
        public const int PopulationCount = 100;

        public List<Neighbour> Neighbours { get; set; }

        public World()
        {
            Neighbours = new List<Neighbour>();
        }

        public void Spawn()
        {
            // Generate {PopulationCount} neighbours
            for(int i = 0; i < PopulationCount; i++)
            {
                this.Neighbours.Add(GenerateNeighbor());
            }
        }

        private Neighbour GenerateNeighbor()
        {
            List<int> sequence = Enumerable.Range(0, 10).ToList();

            sequence.Shuffle();

            return new Neighbour(sequence);
        }

        public void DoGeneration()
        {
            throw new NotImplementedException();
        }

        public Neighbour GetBestNeighbour()
        {
            return Neighbours.OrderBy(n => n.GetFitness()).FirstOrDefault();
        }
    }
}
