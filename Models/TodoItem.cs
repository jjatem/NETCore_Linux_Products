using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class TodoItem
    {
        private static long IdCounter = 0;

        [Key]
        public long Key {get;set;}
        public string Name {get;set;}
        public bool IsComplete {get;set;}

        public TodoItem()
        {
            IdCounter++;
            this.Key = IdCounter;
        }

    }
}