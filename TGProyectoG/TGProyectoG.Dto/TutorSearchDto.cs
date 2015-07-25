using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using TGProyectoG.Data;

namespace TGProyectoG.Dto
{
    public class TutorSearchDto
    {
        public List<Tutor> TutorListResult { get; set; }

        [Display(Name = "Buscar por Nombre de Tutor")]
        public string SearchString { get; set; }
    }
}
