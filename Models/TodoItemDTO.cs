using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAPI.Models
{
    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string IsComplete { get; set; }
    }
}
