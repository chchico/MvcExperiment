namespace MvcExperiment.GridMvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using MvcExperiment.GridMvc.Enums;

    public class Caractor
    {
        public Caractor(int id, string firstName, string lastName, CaractorSexCd sex, CaractorCategoryCd category)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Sex = sex;
            this.Category = category;
        }

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public CaractorSexCd Sex { get; set; }

        public CaractorCategoryCd Category { get; set; }
    }
}