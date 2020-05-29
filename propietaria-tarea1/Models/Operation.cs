using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using propietaria_tarea1.Models;


namespace propietaria_tarea1.Models
{
    public class Operation
    {
        [Display(Name = "Number1")]
        public double Number1 { get; set; }

        [Display(Name = "Number2")]
        public double Number2 { get; set; }

        [Display(Name = "Result")]
        public double Result { get; set; }

        [Display(Name = "Operation")]
        public OperationType OperationType { get; set; }
    }
}
