using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DomainLib
{
    public class Person : IValidatableObject
    {
        [Required]
        public string Name { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return Array.Empty<ValidationResult>();
        }
    }
}
