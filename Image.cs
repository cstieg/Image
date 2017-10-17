using System.ComponentModel.DataAnnotations;

namespace Cstieg.Image
{
    public class WebImage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string ImageUrl { get; set; }

        [StringLength(1000)]
        public string ImageSrcSet { get; set; }

        [StringLength(100)]
        public string Caption { get; set; }
    }
}
