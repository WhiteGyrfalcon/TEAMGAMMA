using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static GamaGameHub.Infrastructure.Data.Constants.EntityConstraints.PostConstraints;

namespace GamaGameHub.Infrastructure.Data.Entities
{
    public class Post
    {
        public Post()
        {
            this.IsActive = true;
            this.CreatedOn = DateTime.Now;
            this.Likes = 0;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(GameCreator))]
        public int GameCreatorId { get; set; }

        public GameCreator GameCreator { get; set; }

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

        public DateTime UpdatedOn { get; set;}

        public int Likes { get; set; }

        public bool IsActive { get; set; }

        public ICollection<PostComment> Comments { get; set; } = new HashSet<PostComment>();
        public ICollection<Image> Images { get; set; } = new HashSet<Image>();
    }
}
