﻿using System;

namespace CodeBlogFitness1.BL.Model
{
    [Serializable]

    public  class Food
    {
        public int Id { get; set; }

        public string Name { get; set; }
         
        /// <summary>
          /// Белки
          /// </summary>
        public double Proteins { get; set; }
        
        /// <summary>
         /// Жиры
         /// </summary>
        public double Fats { get; set; }
        
        /// <summary>
         /// Углеводы
         /// </summary>
        public double Carbohydrates { get; set; }
       
        /// <summary>
        /// Калории за 100 грамм продукта 
        /// </summary>
        public double Calories { get; set; }

        private double CalloriesOneGramm { get { return Calories / 100.0; } }
        private double ProteinsOneGramm { get { return Proteins / 100.0; } }
        private double FatsOneGramm { get { return Fats / 100.0; } }
        private double CarbohydratesOneGramm { get { return Carbohydrates / 100.0; } }


        public Food(string name): this (name, 0, 0, 0, 0) { }
        

        public Food(string name, double callories, double proteins, double fats, double carbohydates )
        {
            //TODO: проверка
            Name = name;
            Calories = callories/100.0;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydrates = carbohydates / 100.0;
              
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
