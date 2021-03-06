﻿using Immobiles.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Immobiles.Domain
{
    public class Announcement : Entity
    {
        //area util
        public decimal UsefulArea { get; set; }
        //quarto
        public int Bedroom { get; set; }
        //banheiro
        public int Bathroom { get; set; }
        public int Suite { get; set; }
        //vaga
        public int Vacancy { get; set; }
        //andar
        public int Walk { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public decimal CondominiumValue { get; set; }
        public decimal Iptu { get; set; }
        public Guid UserId { get; set; }
        public Guid ImmobileId { get; set; }
        public User User { get; set; }
        public Immobile Immobile { get; set; }

        public Announcement()
        {

        }

        public Announcement(decimal usefulArea, int bedroom, int bathroom, int suite, int vacancy, int walk, string description, decimal value, decimal condominiumValue, decimal iptu, User user, Immobile immobile)
        {
           
            UsefulArea = usefulArea;
            Bedroom = bedroom;
            Bathroom = bathroom;
            Suite = suite;
            Vacancy = vacancy;
            Walk = walk;
            Description = description;
            Value = value;
            CondominiumValue = condominiumValue;
            Iptu = iptu;
            UserId = user.Id;
            ImmobileId = immobile.Id;
            User = user;
            Immobile = immobile;
        }
    }
}
