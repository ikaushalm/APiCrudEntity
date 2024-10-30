using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using APiCrudEntity.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;

namespace APiCrudEntity.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public int Age { get; set; }


    }


}
