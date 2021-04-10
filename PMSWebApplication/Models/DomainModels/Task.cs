using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMSWebApplication.Models.DomainModels
{
    public class Task
    {
        public Task()
        {
            Payments = new HashSet<Payment>();
            EmployeeAssignments = new HashSet<EmployeeAssignment>();
        }
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Task Name")]
        public string TaskName { get; set; }

        [Required]
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }

        [Required]
        public string TaskStatus { get; set; }

        [Required]
        [Display(Name = "Stages")]
        public int TaskStages { get; set; }

        [Required]
        [Display(Name = "Task wise Payment")]
        public decimal? TaskWisePayment { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Payment Due Date")]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? PaymentDueDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? SDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Deadline")]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Deadline { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? EDate { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Assign Employee")]
        public string AssignedEmployee { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Task Description")]
        public string TaskDescription { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<EmployeeAssignment> EmployeeAssignments { get; set; }

    }
}
