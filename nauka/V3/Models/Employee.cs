using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace nauka.V3.Models
{
    public class Employee: IEntity<Guid>
    {
        [Key]
        [StringLength(36)]
        public Guid Id { get; set; }
       
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(70)]
        public string Surname { get; set; }
        
        [Required]
        [MaxLength(16)]
        public string Username { get; set; }
        
        [Required]
        [MinLength(8)]
        [MaxLength(16)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }        
        
        [Required]
        public char Sex { get; set; }
        
        [Required]
        public bool EmployeePermisson { get; set; }
        
        [Required]
        public bool VacationPermisson { get; set; }
        
        
        [StringLength(36)]
        public Guid? SectionId { get; set; }

        
        public Section Section { get; set; }
        
        public List<VacationOfEmployee> VacationOfEmployees { get; set; }


        [StringLength(36)]
        public Guid? AppSetting { get; set; }
        
        public AppSettings AppSettings { get; set; }


    }
}
