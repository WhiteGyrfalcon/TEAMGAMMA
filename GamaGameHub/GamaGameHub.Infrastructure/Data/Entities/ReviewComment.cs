using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static GamaGameHub.Infrastructure.Data.Constants.EntityConstraints.ReviewCommentConstraints;

namespace GamaGameHub.Infrastructure.Data.Entities
{
    public class ReviewComment
    {
        public ReviewComment()
        {
            this.IsActive = true;
            this.Likes = 0;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public User User { get; set; }

        [Required]
        [ForeignKey(nameof(Review))]
        public int ReviewId { get; set; }

        public Review Review { get; set; }

        public int Likes { get; set; }

        public bool IsActive { get; set; }
    }
}
