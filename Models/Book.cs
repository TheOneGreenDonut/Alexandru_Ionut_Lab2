using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Alexandru_Ionut_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        public required string Title { get; set; }
        public required string Author { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; } // Navigation property

        private object? publisherAddress;

        public object GetPublisherAddress()
        {
            return publisherAddress;
        }

        internal void SetPublisherAddress(object value)
        {
            publisherAddress = value;
        }
    }

}
