using Microsoft.AspNetCore.Mvc;
using NoteWebApp.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace NoteWebApp.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class NoteController : Controller
    {
        //ilerde statik olarak verileri denemek için bir list oluşturdum.

        private static List<Note> NoteList = new List<Note>()
        {
            new Note{
                Id = 1,
                Title = "Hızlı Notlar",
                Content = "Lorem ipsum",
                Category = 1, // Günlük Notlar
                PublishDate = new DateTime(2001,06,12)
            },
            new Note{
                Id = 2,
                Title = "Alınacak Meyveler",
                Content = "Lorem ipsum",
                Category = 2, //Alışveriş Notları
                PublishDate = new DateTime(2010,08,22)
            },
            new Note{
                Id = 3,
                Title = "Swagger Nedir ? ",
                Content = "Lorem ipsum",
                Category = 3, //İş Notları
                PublishDate = new DateTime(2015,12,21)
            }

        };

        // bütün verileri getiren bir method ekledim

        [HttpGet]
        public List<Note> GetNotes()
        {

            var noteList = NoteList.OrderBy(x => x.Id).ToList<Note>();
            return noteList;

        }
        // belirli bir notun id'sini getiren bir method ekledim.

        [HttpGet("{id}")]
        public Note GetById(int id)
        {

            var note = NoteList.Where(note => note.Id == id).SingleOrDefault();
            return note;
        }

        //Not ekleyebilmek için Post metodu oluşturdum.

        [HttpPost]
        public IActionResult AddNote([FromBody] Note newNote)
        {

            var note = NoteList.SingleOrDefault(x => x.Title == newNote.Title);
            if (note is not null)
                return BadRequest();

            NoteList.Add(newNote);
            return Ok();
        }

        //oluşturulan notu güncellemek veya değiştirmek için Put metodunu oluşturdum.

        [HttpPut("{id}")]
        public IActionResult UpdateNote(int id, [FromBody] Note updatedNote)
        {

            var note = NoteList.SingleOrDefault(x => x.Id == id);

            if (note is null)
                return BadRequest();

            note.Title = updatedNote.Title != default ? updatedNote.Title : note.Title;
            note.Content = updatedNote.Content != default ? updatedNote.Content : note.Content;
            note.Category = updatedNote.Category != default ? updatedNote.Category : note.Category;
            note.PublishDate = updatedNote.PublishDate != default ? updatedNote.PublishDate : note.PublishDate;
            

            return Ok();

        }

        //Oluşturulan notları silmek için Delete metodunu kullandım.

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {

            var note = NoteList.SingleOrDefault(x => x.Id == id);

            if (note is null)
                return BadRequest();

            NoteList.Remove(note);
            return Ok();
        }




    }
}
