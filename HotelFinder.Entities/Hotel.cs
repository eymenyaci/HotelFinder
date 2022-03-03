using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelFinder.Entities
{
    public class Hotel
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int Id { get; set; }
        [StringLength(50)]
        [Required]
       public String Name { get; set; }
        [StringLength(50)]
        [Required]
        public String City { get; set; }
      

    }
}
