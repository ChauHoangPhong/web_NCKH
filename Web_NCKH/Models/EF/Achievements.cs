using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_NCKH.Models.EF
{
    [Table("tb_Achievements")]
    public class Achievements:CommonAbstract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Details { get; set; }
        public int AchievementsDateID { get; set; }
        public int AchievementsCategoryID { get; set; }
        public virtual AchievementsCategory AchievementsCategory { get; set; }
        public virtual AchievementsDate AchievementsDate { get; set; }

    }
}