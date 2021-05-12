using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Model
{
    public class Todo
    {
        [Key]
        public string id { get; set; }
        public string content { get; set; }
        public bool done { get; set; }
    }
}
