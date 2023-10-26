using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Infrastructure.Data.Entities
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UrlPath { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
