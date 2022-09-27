using System;
using System.ComponentModel.DataAnnotations;

namespace MultiPageContactsMeis.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        public string PhoneNum { get; set; }

        [Required(ErrorMessage = "Please enter an address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a note.")]
        public string Note { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower();
    }
}
