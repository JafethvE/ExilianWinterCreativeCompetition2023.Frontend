﻿namespace ExilianWinterCreativeCompetition2023.Frontend
{
    class Animal
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
