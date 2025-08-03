using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryAPI.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        [JsonIgnore]
        public Customer Customer { get; set; }

        public List<OrderItem> OrderItems { get; set; }

    }
}
