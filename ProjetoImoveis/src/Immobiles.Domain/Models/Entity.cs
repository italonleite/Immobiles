using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Immobiles.Domain.Models
{
    public abstract class Entity
    {

        public ValidationResult ValidationResult { get; protected set; }

        public virtual bool IsValid()
        {
            throw new NotImplementedException();
        }
    }                                              
}
