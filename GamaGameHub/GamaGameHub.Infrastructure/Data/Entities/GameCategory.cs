using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Infrastructure.Data.Entities
{
    public class GameCategory
    {
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int CategoryId {  get; set; }
        public Category Category { get; set; }
    }
}
