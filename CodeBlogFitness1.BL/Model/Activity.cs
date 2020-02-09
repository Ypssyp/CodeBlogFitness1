﻿using System;

namespace CodeBlogFitness1.BL.Model
{
    [Serializable]
    public class Activity
    {
       public int Id { get; set; }
       public string Name { get; set; }

        public double CaloriesPerMinute { get; set; }

        public Activity(string name, double caloriesPerMinute)
        {
            //Проверка

            Name = name;
            CaloriesPerMinute = caloriesPerMinute;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
