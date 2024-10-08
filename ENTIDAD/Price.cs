using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_ENTIDAD
{
    public class Price
    {
        [Key, Column(Order = 0)]
        public int NumberOfDays { get; set; }  // Número de días
        [Key, Column(Order = 1)]
        public int PriceValue { get; set; }  // Precio asociado

        // Método para calcular el precio por día
        public int GetPricePerDay()
        {
            return PriceValue / NumberOfDays;
        }
    }
}