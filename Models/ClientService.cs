using RazorPages.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesZenSpaCh7.Models
{
    [Table("ClientService")]
    public class ClientService
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey(nameof(Client))]
        [Display(Name = "Client")]
        public int ClientID { get; set; }

        [ForeignKey(nameof(Services))]
        [Display(Name = "Service")]
        public int ServicesID { get; set; }

        // nav props (optional but useful for scaffolding & FK generation)
        public Client? Client { get; set; }
        public Services? Services { get; set; }
    }
}
