using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Homework6_CSHP_220.Models
{
    public class SignerResponse
    {
        [Required(ErrorMessage = "Please enter from field")]
        public string From { get; set; }

        [Required(ErrorMessage = "Please enter to field")]
        public string To { get; set; }

        [Required(ErrorMessage = "Please enter a message")]
        public string Message { get; set; }
    }
}