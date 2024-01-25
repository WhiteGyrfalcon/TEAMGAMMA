using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Infrastructure.Data.Entities
{
    public class GameGenre
    {
        [ForeignKey(nameof(Game))]
        public int GameId {  get; set; }
        public Game Game {  get; set; }

        [ForeignKey(nameof(Genre))]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
