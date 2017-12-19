using comicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                // Titeln
                SeriesTitle = "The Amazing Spider Man",
                //Vilket nummer
                IssueNumber = 700,
                //Beskrivning, i htmlformat
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                // lista av "artists"
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script"},
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils"},
                    new Artist() { Name = "Victor Olazaba", Role = "Inks"},
                    new Artist() { Name = "Edgar Delgado", Role = "Colors"},
                    new Artist() { Name = "Chris Eliopoulos", Role = "Letters"},
                }
            };

            return View(comicBook);
        }
    }
}
