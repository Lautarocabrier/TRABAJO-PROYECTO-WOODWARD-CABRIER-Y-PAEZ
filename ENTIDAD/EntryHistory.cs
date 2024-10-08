using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C4_ENTIDAD
{
    public class EntryHistory : Entry
    {
        [Key]
        public int Id { get; set; }  // Identificador del historial de entrada

        public int UserId { get; set; }  // Clave foránea para User
        [ForeignKey("UserId")]
        public virtual User User { get; set; }  // Relacion con User

        public DateTime EntryDate { get; set; }  // Fecha de entrada
        public DateTime? ExitDate { get; set; }  // Fecha de salida
        public DateTime CurrentDate { get; set; }  // Fecha actual heredado de entry

        public TimeSpan Duration => ExitDate.HasValue ? ExitDate.Value - EntryDate : TimeSpan.Zero;  // Calcula la duración de la estancia

        // Métodos para registrar entradas y salidas
        public void RegisterEntry(int userId)
        {
            UserId = userId;
            EntryDate = DateTime.Now;
        }

        public void RegisterExit()
        {
            ExitDate = DateTime.Now;
        }

        public TimeSpan GetDuration()
        {
            return Duration;
        }
    }
}