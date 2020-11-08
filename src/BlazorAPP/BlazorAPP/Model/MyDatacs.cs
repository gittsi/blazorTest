using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAPP.Model
{
    public class MyDatacs
    {
        [Required]
        
        //[MaxLength(2, ErrorMessage = "number is too long.")]  
        
        public int TheNumber { get; set; }

    }
}
