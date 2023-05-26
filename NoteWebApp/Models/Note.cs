using System;

namespace NoteWebApp.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Category { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
