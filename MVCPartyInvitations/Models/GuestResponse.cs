using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPartyInvitations.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage="Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your Email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        [RegularExpression("[0-9]{5}-[0-9]{6}", ErrorMessage = "Please enter a valid phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please say whether you're coming")]
        public bool? WillAttend { get; set; }
        public string Password { get; set; }
    }
}