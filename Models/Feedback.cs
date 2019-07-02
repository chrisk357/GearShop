using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GearShop.Models
{
    public class Feedback
    {
        [BindNever]
        public int FeedbackId { get; set; }
        [Required, StringLength(100, ErrorMessage ="Your name is required!")]
        public string Name { get; set; }
        [Required, StringLength(100, ErrorMessage ="Your Email is required!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required, StringLength(5000, ErrorMessage = "Dont forget your message")]

        public string Message { get; set; }
    }
}
