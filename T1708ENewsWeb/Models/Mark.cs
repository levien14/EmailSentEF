using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace T1708ENewsWeb.Models
{
    public class Mark
    {
        public int id { get; set; }
        public string SubjectName { get; set; }
        [checkeSN]
        public int SubjectMark { get; set; }
        public string StudentRollNumber { get; set; }
        [ForeignKey("StudentRollNumber")]
        public Student Student { get; set; }
        public class checkeSNAttribute : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                Mark mark = (Mark)validationContext.ObjectInstance as Mark;

                if (mark.SubjectMark <= 0 || mark.SubjectMark >= 25)
                {
                    return new ValidationResult("0 <= Mark <= 25");
                }

                return ValidationResult.Success;
            }
        }
    }
}
