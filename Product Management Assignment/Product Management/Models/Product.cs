//------------------------------------------------------------------------------
//Product Model
//------------------------------------------------------------------------------
namespace Product_Management.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "enter productname")]
        public string ProductName { get; set; }


        [Required(ErrorMessage = "enter Categoeryname")]
        public string Categoery { get; set; }


        [Required(ErrorMessage = "enter Price")]
        public decimal Price { get; set; }



        [Required(ErrorMessage = "enter Quantity ")]
        public int Quantity { get; set; }


        [Required(ErrorMessage = "enter Description")]
        [Display(Name = "Description")]
        public string Short_Description { get; set; }


        [Display(Name = "Image")]
        public string Small_Image { get; set; }
    }
}
public enum Categoery
{
    Appliances,
    Beauty,
    Electronics,
    Fashion,
    Food,
    Grocery,
    Home,
    Mobile,
    Toy

}
