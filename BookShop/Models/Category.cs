﻿using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class Category

    {

        // PK fields should always be called either {Model}Id or just Id

        public int CategoryId { get; set; }



        [Required(ErrorMessage = "A customized error message")]

        public string Name { get; set; }



        // child reference to Books (1 Category / Many Books)

        public List<Book>? Books { get; set; }

    }
}
