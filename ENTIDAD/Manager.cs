using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_ENTIDAD
{
    public class Manager
    {
        [Key]
        public int GymId { get; set; }  // Identificador del gimnasio

        public string Name { get; set; }  // Nombre del manager o gimnasio
        public string TaxId { get; set; }  // Identificación fiscal (CUIT)

        // Listas de usuarios clasificados por su estado
        public virtual ICollection<User> General { get; set; }  // Todos los usuarios
        public virtual ICollection<User> OwesSubscription { get; set; }  // Usuarios que deben suscripción
        public virtual ICollection<User> Inactive { get; set; }  // Usuarios inactivos
        public virtual ICollection<User> InGoodStanding { get; set; }  // Usuarios en regla
        public virtual ICollection<User> Training { get; set; }  // Usuarios en entrenamiento
    }
}