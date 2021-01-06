//------------------------------------------------------------------------------
//Account Model
//------------------------------------------------------------------------------

namespace Product_Management.Models
{
    using Product_Management.customvalidation;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class Account
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter FirstName!")]
        [StringLength(50)]
        [Display(Name = "FirstName")]
        public string Firstname { get; set; }



        [Required(ErrorMessage = "Enter LastName!")]
        [MaxLength(50), MinLength(2)]
        public string Lastname { get; set; }



        [Required(ErrorMessage = "Select Male and Female!")]
        public string Gender { get; set; }


        [Required(ErrorMessage = "Enter Age!")]
        [Range(18, 100, ErrorMessage = "Age must be between 18 to 100")]
        public int Age { get; set; }




        [Display(Name = "DOB")]
        [DisplayFormat(DataFormatString = "{0:D}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]

        public System.DateTime DOB { get; set; }


        [Required(ErrorMessage = "Enter Phone no!")]
        [Display(Name = "Phone no.")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(13, MinimumLength = 10)]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Not a valid Phone number")]
        public string Phone { get; set; }


        [Required(ErrorMessage = "Enter Email Address!")]
        [Display(Name = "Email")]
        [emailvalid]

        //[RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Password!")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [RegularExpression("([a-z]|[A-Z]|[0-9]|[\\W]){4}[a-zA-Z0-9\\W]{3,11}$", ErrorMessage = "Enter AtLest 8 Charater , one Special Symbol  and one UpperCase Letter")]



        public string Password { get; set; }
        [Required(ErrorMessage = "Enter RePassword!")]
        [Display(Name = "Re-Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password is not identical")]
        public string Conform_Password { get; set; }



        [Required(ErrorMessage = "Enter Address!")]
        [ScaffoldColumn(true)]
        public string Address { get; set; }


    }
}
