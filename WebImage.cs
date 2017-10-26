using System.ComponentModel.DataAnnotations;

namespace Cstieg.Image
{
    public class WebImageBase
    {
        [Key]
        public virtual int Id { get; set; }

        [Required]
        [StringLength(200)]
        public virtual string ImageUrl { get; set; }

        [StringLength(1000)]
        public virtual string ImageSrcSet { get; set; }

        [StringLength(100)]
        public virtual string Caption { get; set; }
    }
}
