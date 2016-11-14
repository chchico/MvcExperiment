namespace MvcExperiment.GridMvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using MvcExperiment.GridMvc.Enums;

    public class Caractor
    {
        public Caractor(string firstName, string lastName, int age, CaractorCategoryCd category)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Category = category;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public CaractorCategoryCd Category { get; set; }
    }
}