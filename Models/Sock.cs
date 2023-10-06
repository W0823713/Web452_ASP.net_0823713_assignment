using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AryaSock.Models
{
    public class Sock
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [StringLength(30)]
        [Required]
        public string Material { get; set; } // Updated data annotations

        [StringLength(10)]
        [Required]
        public string Size { get; set; } // Updated data annotations

        [StringLength(20)]
        [Required]
        public string Color { get; set; } // Updated data annotations

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [EnumDataType(typeof(CustomRatingScale))]
        [Required]
        public CustomRatingScale Rating { get; set; }
    }

    public enum CustomRatingScale
    {
        [Display(Name = "Poor")]
        One = 1,

        [Display(Name = "Fair")]
        Two = 2,

        [Display(Name = "Good")]
        Three = 3,

        [Display(Name = "Very Good")]
        Four = 4,

        [Display(Name = "Excellent")]
        Five = 5
    }
}
