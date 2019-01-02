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
        public string NameofBusiness { get; set; }
        public string TypeofBusiness { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }        
        public string Website { get; set; }        
        public string AboutBusiness { get; set; }
        public string Services { get; set; }
        public string BestPrice { get; set; }
        public byte[] Document { get; set; }
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