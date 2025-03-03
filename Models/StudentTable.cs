using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OreratileStudyGroup.Models
{
    public class StudentTable
    {
        [DisplayName("STUDENT NUMBER")]
        public string StudentNo { get; set; }

        [DisplayName("NAME")]
        public string StudentName { get; set;}

        [DisplayName("SURNAME")]
        public string StudentSurname { get; set;}

        [DisplayName("EMAIL")]
        public string StudentEmail { get; set;} 
    }
}