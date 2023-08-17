using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_NCKH.Models.EF
{
    [Table("tb_LocationCategory")]
    public class LocationCategory : CommonAbstract
    {
        public LocationCategory()
        {
            this.Members = new HashSet<Member>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Title { get; set; }
        public string Alias { get; set; }
        public ICollection<Member> Members{ get; set; }
    }
}