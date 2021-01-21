﻿namespace ApiProducto.Models
{
    using System.ComponentModel.DataAnnotations;
    public enum MarketType
    {
        niños=0,
        jovenes =1,
        hombres =2,
        mujeres=3,
        viejos=4,
    }
    public enum CategoryType 
    { 
        ropa=0,
        electronicos=1,
        cosmeticos=2,
        muebleria=3,
        juegos=4,
        deportes=5,
        bebidas=6,
        alimentos=7,
    }
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(80,ErrorMessage ="Muy grande tu nombre, entre 5 a 80 caracteres porfavor",MinimumLength =5)]
        public string Name { get; set; }
        [Range(0, 10000, ErrorMessage = "El precio oscila entre 0 a 10000")]
        public double Price { get; set; }
        public MarketType Market{ get; set;}

        public  CategoryType Category { get; set; }


    }
}