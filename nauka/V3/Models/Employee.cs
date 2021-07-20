using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace nauka.V3.Models
{
    public class Employee: IEntity<Guid>
    {

        [StringLength(36)]
        public Guid Id { get; set; }     
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(70)]
        public string Surname { get; set; }
        [MaxLength(16)]
        public string Username { get; set; }
        [MinLength(8)]
        [MaxLength(16)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }        
        public char Sex { get; set; }
        public bool EmployeePermisson { get; set; }
        public bool VacationPermisson { get; set; }
                 
        //relation properties
        [StringLength(36)]
        public Guid? SectionId { get; set; }     
        public Section Section { get; set; }
        
        public List<Vacation_Employee> Vacation_Employees { get; set; }
       
        [StringLength(36)]
        public virtual Guid AppSettinsgId { get; set; }
        public AppSettings AppSettings { get; set; }


    }
}
