using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TareasMVC.Entities;

public class Tarea
{
    [Column("id")] public int Id { get; set; }

    [Column("titulo")]
    [StringLength(250)]
    [Required]
    public string Titulo { get; set; }

    [Column("descripcion")] public string Descripcion { get; set; }
    [Column("orden")] public int Orden { get; set; }
    [Column("fechaCreacion")] public DateTime FechaCreacion { get; set; }
    public IEnumerable<Paso> Pasos { get; set; }
    public IEnumerable<ArchivoAdjunto> ArchivosAdjuntos { get; set; }
}