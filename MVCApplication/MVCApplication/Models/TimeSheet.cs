using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCApplication.Models
{
    public class TimeSheet
    {
        [Key]
        public int id { get; set; }
       
        [Required]
        [Index(IsUnique = true)]
        public int employeeID { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }
        [DataType(DataType.Time)]
        [BindProperty]
        public DateTime EndTime { get; set; }

        [ReadOnly(true)]
        public decimal Hoursofwork { get; set; }
        [Required]
        public int projectID { get; set; }
        [Required]
        public int taskID { get; set; }

    }
}
