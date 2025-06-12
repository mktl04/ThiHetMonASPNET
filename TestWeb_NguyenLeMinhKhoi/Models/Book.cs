using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestWeb_NguyenLeMinhKhoi.Models
{
    public class Book
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
