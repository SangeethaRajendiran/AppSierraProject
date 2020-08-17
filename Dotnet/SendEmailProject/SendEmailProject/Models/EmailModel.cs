using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SendEmailProject.Models
{

    public class EmailModel
    {


        public string SenderEmail { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string To { get; set; }

        [Required(ErrorMessage = "Subject is required.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Body is required.")]
        public string Body { get; set; }


    }

}
