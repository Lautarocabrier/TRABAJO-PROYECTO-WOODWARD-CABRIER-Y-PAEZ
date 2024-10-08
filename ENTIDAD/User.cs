using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_ENTIDAD
{
    public class User
    {
        [Key]
        public int Id { get; set; }  // Identificador del usuario

        public string FirstName { get; set; }  // Nombre del usuario
        public string LastName { get; set; }  // Apellido del usuario
        public int Age { get; set; }  // Edad del usuario
        public string IdNumber { get; set; }  // Número de identificación (DNI)
        public string Email { get; set; }  // Correo electrónico del usuario
        public int MonthlySubscription { get; set; }  // Cuota mensual

        // Relaciones con otras clases
        public int GymId { get; set; }  // Clave foránea para Manager
        [ForeignKey("GymId")]
        public virtual Manager Manager { get; set; }  // Relación con Manager

        public virtual ICollection<Activity> Activities { get; set; }  // Actividades en las que participa
        public virtual ICollection<EntryHistory> PersonalHistory { get; set; }  // Historial personal de entradas y salidas
    }
}