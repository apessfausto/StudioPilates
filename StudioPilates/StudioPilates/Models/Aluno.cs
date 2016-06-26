using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioPilates.Models
{
    [Table("Alunos")]
    class Aluno
    {
        [Key]
        public int AlunoId { get; set; }
        public string AlunoNome { get; set; }
        public string AlunoCpf { get; set; }
        public string AlunoTelefone { get; set; }
        public string AlunoIdade { get; set; }
    }
}
