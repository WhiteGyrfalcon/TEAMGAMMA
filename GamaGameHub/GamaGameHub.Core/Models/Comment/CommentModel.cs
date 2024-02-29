using GamaGameHub.Core.Models.User;

namespace GamaGameHub.Core.Models.Comment
{
    public class CommentModel
    {
        public int Id { get; set; }
        public UserPartialModel Creator { get; set; }
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }
        public int Likes { get; set; }
        public bool IsActive { get; set; }
    }
}
