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

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(ShortContentMaxLength)]
        public string ShortContent { get; set; }

        [Required]
        [MaxLength(MainContentMaxLength)]
        public string MainContent { get; set; }

        public DateTime CreatedOn { get; set; }

        [Required]
        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }

        public Game Game { get; set; }

        [Required]
        [Range(StarsMax, StarsMin)]
        public int Stars { get; set; }

        public int Likes { get; set; }

        public bool IsActive { get; set; }

        public ICollection<ReviewComment> GameComments { get; set; } = new HashSet<ReviewComment>();
    }
}
