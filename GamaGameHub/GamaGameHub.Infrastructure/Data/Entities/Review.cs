using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static GamaGameHub.Infrastructure.Data.Constants.EntityConstraints.ReviewConstraints;

namespace GamaGameHub.Infrastructure.Data.Entities
{
    // This should be renamed
    public class Review
    {
        public Review()
        {
            this.IsActive= true;
            this.Likes = 0;
            this.CreatedOn= DateTime.Now; 
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public User User { get; set; }

        // This should be unnecessary
        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; }

        // This should be unnecessary
        [Required]
        [MaxLength(ShortContentMaxLength)]
        public string ShortContent { get; set; }

        // This should be renamed
        [Required]
        [MaxLength(MainContentMaxLength)]
        public string MainContent { get; set; }

        public DateTime CreatedOn { get; set; }

        [Required]
        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }

        public Game Game { get; set; }

        // This should be unnecessary
        [Required]
        [Range(StarsMax, StarsMin)]
        public int Stars { get; set; }

        public int Likes { get; set; }

        public bool IsActive { get; set; }

        // This should be unnecessary
        public ICollection<ReviewComment> GameComments { get; set; } = new HashSet<ReviewComment>();
    }
}
