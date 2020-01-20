using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeBlogFitness1.BL.Model
{
    [Serializable]     

    public  class Eating
    {
        public DateTime Moment { get; }

        public Dictionary<Food, double > Foods { get; }

        public User User { get; }

        public Eating(User user)
        {
            //TODO: проверка
            User = user ?? throw new ArgumentNullException("Пользователь не может быть пустым.", nameof(user));
            Moment = DateTime.UtcNow;
            Foods = new Dictionary<Food, double>();
        }

        public void Add(Food food, double weight)
        {
            var product = Foods.Keys.FirstOrDefault(f => f.Name.Equals(food.Name));
            if(product==null)
            {
                Foods.Add(food, weight);
            }
            else
            {
                Foods[product] += weight;
            }
        }
    }
}
                                                        