﻿using CodeBlogFitness1.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeBlogFitness1.BL.Controller
{
    public class DatabaseDatasaver<T> : IDataSaver <T> where T:class
    {


        public List<T> Load() 
        {
            using (var db = new FitnessContext())
            {
                var result = db.Set<T>().Where(l => true).ToList()  ;
                return result;   
            }
         
        }

        public void Save(T item)
        {
            using (var db = new FitnessContext())
            {
                db.Set<T>().Add(item);
                db.SaveChanges();
            }
        }
    }
}
