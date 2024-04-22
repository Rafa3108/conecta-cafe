using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConectaCafe.Models;

[Table("Avaliacao")]
public class Avaliacao
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Display(Name = "Nome")]
    [StringLength(60)]
    [Required(ErrorMessage = "Por favor, insira um nome")]
    public string Pessoa { get; set; }   

    [Display(Name = "Texto")]
    [StringLength(500, ErrorMessage = "O texto deve possuir no máximo 500 caracteres")]
    [Required(ErrorMessage = "Por favor, insira o texto")]
    public string Texto { get; set; }

    [Display(Name = "Nota")]
    [Column(TypeName = "decimal(1,0)")]
    [Required(ErrorMessage = "Por favor, informe a nota")]
    public decimal Nota { get; set; } = 5;

    [Display(Name = "Data da Avaliação")]
    [DataType(DataType.Date)]
    public DateTime DataAvaliacao { get; set; } = DateTime.Now;
    
   
    [StringLength(200)]
    public string Foto { get; set; }   
}


  
