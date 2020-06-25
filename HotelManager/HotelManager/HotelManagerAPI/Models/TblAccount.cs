﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace HotelManager.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class TblAccount
    {
        /// <summary>
        /// Initializes a new instance of the TblAccount class.
        /// </summary>
        public TblAccount() {
            
        }

        /// <summary>
        /// Initializes a new instance of the TblAccount class.
        /// </summary>
        public TblAccount(string pass, string name, string username = default(string))
        {
            Username = username;
            Pass = pass;
            Name = name;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Username")]
        public string Username { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Pass")]
        public string Pass { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Pass == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Pass");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (this.Username != null)
            {
                if (this.Username.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Username", 50);
                }
                if (this.Username.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Username", 0);
                }
            }
            if (this.Pass != null)
            {
                if (this.Pass.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Pass", 50);
                }
                if (this.Pass.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Pass", 0);
                }
            }
            if (this.Name != null)
            {
                if (this.Name.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 50);
                }
                if (this.Name.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 0);
                }
            }
        }
    }
}
