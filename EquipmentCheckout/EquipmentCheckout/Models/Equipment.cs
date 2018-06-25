using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace EquipmentCheckout.Models
{
    public class Equipment
    {
        public int ID { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11)]
        [RegularExpression(@"^INC[0-9]{8}$",
            ErrorMessage = "Incident must be in INC######## form")]
        public string Incident { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 5)]
        public string User { get; set; }

        [StringLength(60, MinimumLength = 5)]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Phone")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Phone number must be 10 numbers.")]
        public long UserPhone { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
            ErrorMessage = "E-mail must be in email@domain.com form.")]
        public string UserEmail { get; set; }

        [Required]
        [Display(Name = "Checkout Date")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CheckoutDate { get; set; }

        [Display(Name = "Return Date")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReturnDate { get; set; }

        [Display(Name = "Equipment")]
        public string EquipmentCheckedOut { get; set; }

        [Display(Name ="Extra Info")]
        public string ExtraInfo { get; set; }
    }

    public class EquipmentDBContext : DbContext
    {
        public DbSet<Equipment> Checkouts { get; set; }
    }
}