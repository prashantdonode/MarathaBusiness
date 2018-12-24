using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MarathaBusinessApi.Models
{
    public class MarathaBusinessModel
    {
    }


    public class tblSkyAdmin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Sid { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }


    public class tblBusinessManRegistration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Bid { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }
        public string StoreName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public byte Document { get; set; }
        public int Status { get; set; }
    }


    public class tblOccupation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Oid { get; set; }
        public string Occupation { get; set; }
    }


    public class OccupationList
    {
        public string Occupation { get; set; }
    }


    public class ProjectResult
    {
        public string Message { get; set; }
        public int Status { get; set; }
        public object Response { get; set; }
    }
}