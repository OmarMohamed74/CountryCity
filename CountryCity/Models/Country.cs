﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CountryCity.Models
{
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
        }

        public int Id { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<City> City { get; set; }
    }
}