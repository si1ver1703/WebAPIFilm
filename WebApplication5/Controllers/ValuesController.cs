using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication5.Models;
using System.Data;
using System.Data.Entity;

namespace WebApplication5.Controllers
{

    public class ValuesController : ApiController
    {
        FilmContect dbfilm = new FilmContext(); 
        // GET api/values
        public IEnumerable<Film> GetFilms()
        {
            return dbfilm.film;
        }

        // GET api/values/5
        public Film GetFilm(int id)
        {
            Film filmID = dbfilm.film.Find(id);
            return filmID;
        }

        [HttpPost]
        // POST api/values
        public void CreatePost([FromBody] Film postfilm)
        {
            dbfilm.film.Add(postfilm);
            dbfilm.SaveChanges();
        }

        [HttpPut]
        // PUT api/values/5
        public void EditFilm(int id, [FromBody] Film editfilm)
        {
            if(id == editfilm.id)
            {
                dbfilm.Entry(editfilm).State = EntityState.Modified;
                dbfilm.SaveChanges();
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            Book deletefilm = dbfilm.film.Find(id);
            if (deletefilm != null)
            {
                dbfilm.film.Remove(deletefilm);
                dbfilm.SaveChanges();
            }
        }
    }
}
