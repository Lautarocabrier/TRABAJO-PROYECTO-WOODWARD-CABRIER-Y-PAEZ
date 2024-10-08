using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_ENTIDAD
{
    public class Activity
    {
  
        [Key]
        public int Id { get; set; }  // Identificador de la actividad

        public string Name { get; set; }  // Nombre de la actividad
        public string Description { get; set; }  // Descripción de la actividad
        public string Schedule { get; set; }  // Horario de la actividad (puede ser JSON o texto estructurado)

        public virtual ICollection<User> Users { get; set; }  // Relación muchos a muchos con User a través de UserActivity
    }
}