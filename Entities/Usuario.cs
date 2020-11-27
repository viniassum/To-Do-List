using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Usuario")]
    public class Usuario : EntityBase<int>
    {
        [Required]
        [Column("email")]
        public string Email { get; set; }

        [Required]
        [Column("senha")]
        public string Senha { get; set; }
    }
}
