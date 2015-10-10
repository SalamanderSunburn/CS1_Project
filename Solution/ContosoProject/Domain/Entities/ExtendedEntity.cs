﻿using System;
using Domain.Entities.Users;
using System.Net.Configuration;

namespace Domain.Entities
{
    public abstract class ExtendedEntity : Entity
    {
        protected ExtendedEntity(DateTime date, bool isActive) : base(isActive)
        {
            Date = date;
        }

        public User User { get; set; }

        public DateTime Date { get; set; }

     } 
}
