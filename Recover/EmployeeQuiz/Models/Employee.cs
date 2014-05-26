using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EmployeeQuiz.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "El empleado no se encuentra")]
        public string Id{ get; set; }
        
        public string Name { get; set; }
        public string FirstLastname { get; set; }
        public string SecondLastname { get; set; }
        public string Position { get; set; }
        public double Wage { get; set; }
        public char Sex{ get; set; }
        public string PhotoPath { get; set; }
    }
}