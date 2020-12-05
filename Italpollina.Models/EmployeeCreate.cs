using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italpollina.Models
{
    public class EmployeeCreate
    {
        [Required]
        public string Name { get; set; }
    }
}
