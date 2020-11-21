using FluentValidation;
using FluentValidation.Results;
using Immobiles.Domain.Models.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Immobiles.Domain.Models
{
    public class User : Entity
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Announcement> Announcements { get; set; }

        public User()
        {

        }

        public User(string login, string email, string password)
        {
               
            Login = login;
            Email = email;
            Password = password;
        }

        public Announcement CreateAnnouncement(decimal usefulArea, int bedroom, int bathroom, int suite, int vacancy, int walk, string description, int iptu, decimal value, int condominiumValue, User user, Immobile immobile)
        {

            var announcement = new Announcement(usefulArea, bedroom, bathroom, suite, vacancy, walk, description, value, condominiumValue, iptu, user, immobile);
            return announcement;
        }
        
    }

    
}
