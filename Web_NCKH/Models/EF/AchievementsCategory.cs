using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_NCKH.Models.EF
{
    [Table("tb_AchievementsCategory")]
    public class AchievementsCategory:CommonAbstract
    {
        public AchievementsCategory()
        {
            this.Achievements = new HashSet<Achievements>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Title { get; set; }
        public string Alias { get; set; }
        public ICollection<Achievements> Achievements { get; set; }
    }
}