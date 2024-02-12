using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Parameter
{
  public  class Contact
    {
        [Required( ErrorMessage ="110")]
        public string Name { get; set; }
        [Required(ErrorMessage = "111")]
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        [Required(ErrorMessage = "112")]
        public string Message { get; set; }
        public string LangCode { get; set; }
        [Required(ErrorMessage = "113")]
        public string ValidationCode { get; set; }
    }


   
}
