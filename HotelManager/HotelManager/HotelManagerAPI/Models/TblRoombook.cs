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

    public partial class TblRoombook
    {
        /// <summary>
        /// Initializes a new instance of the TblRoombook class.
        /// </summary>
        public TblRoombook() { }

        /// <summary>
        /// Initializes a new instance of the TblRoombook class.
        /// </summary>
        public TblRoombook(string idCard, string idRoom, string staffName, int? idRoombook = default(int?), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), TblCustomer tblCustomer = default(TblCustomer), TblRoom tblRoom = default(TblRoom))
        {
            IdRoombook = idRoombook;
            IdCard = idCard;
            IdRoom = idRoom;
            StartDate = startDate;
            EndDate = endDate;
            StaffName = staffName;
            TblCustomer = tblCustomer;
            TblRoom = tblRoom;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "idRoombook")]
        public int? IdRoombook { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "idCard")]
        public string IdCard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "idRoom")]
        public string IdRoom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "staffName")]
        public string StaffName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tbl_customer")]
        public TblCustomer TblCustomer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tbl_room")]
        public TblRoom TblRoom { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (IdCard == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IdCard");
            }
            if (IdRoom == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IdRoom");
            }
            if (StaffName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StaffName");
            }
            if (this.IdCard != null)
            {
                if (this.IdCard.Length > 12)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "IdCard", 12);
                }
                if (this.IdCard.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "IdCard", 0);
                }
            }
            if (this.IdRoom != null)
            {
                if (this.IdRoom.Length > 5)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "IdRoom", 5);
                }
                if (this.IdRoom.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "IdRoom", 0);
                }
            }
            if (this.StaffName != null)
            {
                if (this.StaffName.Length > 30)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "StaffName", 30);
                }
                if (this.StaffName.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "StaffName", 0);
                }
            }
            if (this.TblCustomer != null)
            {
                this.TblCustomer.Validate();
            }
            if (this.TblRoom != null)
            {
                this.TblRoom.Validate();
            }
        }
    }
}