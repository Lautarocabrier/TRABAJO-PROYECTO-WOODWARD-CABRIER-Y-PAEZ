using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_ENTIDAD
{
    public class Entry
    {
        [Key]
        public int EntryId { get; set; }
        DateTime CurrentDate { get; set; }

        public string Descripcion { get; set; }

    }
}