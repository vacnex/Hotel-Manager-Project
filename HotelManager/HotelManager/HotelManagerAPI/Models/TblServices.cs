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

    public partial class TblServices
    {
        /// <summary>
        /// Initializes a new instance of the TblServices class.
        /// </summary>
        public TblServices() { }

        /// <summary>
        /// Initializes a new instance of the TblServices class.
        /// </summary>
        public TblServices(string serName, string serUnit, string idService = default(string), double? serPrice = default(double?), IList<TblServicesuse> tblServicesuse = default(IList<TblServicesuse>))
        {
            IdService = idService;
            SerName = serName;
            SerPrice = serPrice;
            SerUnit = serUnit;
            TblServicesuse = tblServicesuse;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "idService")]
        public string IdService { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serName")]
        public string SerName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serPrice")]
        public double? SerPrice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serUnit")]
        public string SerUnit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tbl_servicesuse")]
        public IList<TblServicesuse> TblServicesuse { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (SerName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SerName");
            }
            if (SerUnit == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SerUnit");
            }
            if (this.IdService != null)
            {
                if (this.IdService.Length > 10)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "IdService", 10);
                }
                if (this.IdService.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "IdService", 0);
                }
            }
            if (this.SerName != null)
            {
                if (this.SerName.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "SerName", 50);
                }
                if (this.SerName.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "SerName", 0);
                }
            }
            if (this.SerUnit != null)
            {
                if (this.SerUnit.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "SerUnit", 50);
                }
                if (this.SerUnit.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "SerUnit", 0);
                }
            }
            if (this.TblServicesuse != null)
            {
                foreach (var element in this.TblServicesuse)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
