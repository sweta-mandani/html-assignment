//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationForm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;


    public partial class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter FirstName!")]
        [StringLength(50)]
        public string FisrtName { get; set; }

        [Required(ErrorMessage = "Enter LastName!")]
        [MaxLength(50),MinLength(2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Select Male and Female!")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Enter Age!")]
        [Range(18, 60, ErrorMessage = "Age must be between 18 to 60")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Enter Data of Birth!")]
        [Display(Name = "DOB")]
        [DataType(DataType.Date)]
        public System.DateTime DataOfBirth { get; set; }

        [Required(ErrorMessage = "Enter Phone no!")]
        [Display(Name = "Phone no.")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(13,MinimumLength =10)]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Not a valid Phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Enter Email Address!")]
        [Display(Name = "Email Id")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Password!")]
        [Display(Name = "PassWord")]
        [DataType(DataType.Password)]
        [RegularExpression("(?!^[0-9]$)(?!^[a-zA-Z]$)^([a-zA-Z0-9]{8,15})$", ErrorMessage = "Enter AtLest 8 Charater , one Special Symbol  and one UpperCase Letter")]

        public string PassWord { get; set; }
        [Required(ErrorMessage = "Enter RePassword!")]
        [Display(Name = "Re-PassWord")]
        [DataType(DataType.Password)]
        [Compare("PassWord", ErrorMessage = "Password is not identical")]
        public string Conform_PassWord { get; set; }

        [Required(ErrorMessage = "Enter Address!")]
        [ScaffoldColumn(true)]
       
        public string Address { get; set; }

       
        [Display(Name = "Oraganization Name")]
        
        
       
        public string User_Image { get; set; }
    }
}
