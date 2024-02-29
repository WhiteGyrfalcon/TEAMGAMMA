using GamaGameHub.Core.Models.Comment;
using GamaGameHub.Core.Models.User;
using GamaGameHub.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Core.Contracts
{
    public interface ICommentService
    {
        Task Add(string userId, string Content, DateTime dateOfAdding);
        Task GetCommentsByUserId(int userId);
        List<CommentModel> GetCommentsByGame(Game game);
    }
}
