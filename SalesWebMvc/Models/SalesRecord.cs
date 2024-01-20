using SalesWebMvc.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using SalesWebMvc.Attributes;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DateFuture(ErrorMessage = "The date cannot be in the future and after the 2000s")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Seller")]
        public int? SellerId { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Range(10, 100000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        public double Amount { get; set; }

        [Required(ErrorMessage = "Status must be Pending, Billed, canceled")]
        [EnumDataType(typeof(SaleStatus))]
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
