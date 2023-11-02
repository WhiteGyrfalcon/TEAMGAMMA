using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static GamaGameHub.Infrastructure.Data.Constants.EntityConstraints.PostCommentConstraints;

namespace GamaGameHub.Infrastructure.Data.Entities
{
    public class PostComment
    {
        public PostComment()
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
        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }

        public Post Post { get; set; }

        public int Likes { get; set; }

        public bool IsActive { get; set; }
    }
}
