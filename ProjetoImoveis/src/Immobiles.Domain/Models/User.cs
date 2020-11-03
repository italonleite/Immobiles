using FluentValidation;
using FluentValidation.Results;
using Immobiles.Domain.Models.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Immobiles.Domain.Models
{
    public class User 
    {
        public Guid UserId { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Announcement> Announcements { get; set; }

        public User()
        {

        }

        public User(Guid userId, string login, string email, string password)
        {
            UserId = userId;
            Login = login;
            Email = email;
            Password = password;
        }

        public Announcement CreateAnnouncement(Guid announcementId, decimal usefulArea, int bedroom, int bathroom, int suite, int vacancy, int walk, string description, decimal value, User user, Immobile immobile)
        {

            var announcement = new Announcement()
            {
                AnnouncementId = announcementId,
                UsefulArea = usefulArea,
                Bedroom = bedroom,
                Bathroom = bathroom,
                Suite = suite,
                Vacancy = vacancy,
                Walk = walk,
                Description = description,
                Value = value,
                User = user,
                Immobile = immobile
            };


            return announcement;
        }
        
    }

    
}
