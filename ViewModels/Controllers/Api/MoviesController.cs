﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ViewModels.Dtos;
using ViewModels.Models;

namespace ViewModels.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private MyDBContext context;
        public MoviesController()
        {
            context = new MyDBContext();
        }
        //GET /api/movies
        public IEnumerable<MovieDto> GetMovies()
        {
            return context.Movies.ToList().Select(Mapper.Map<Movie, MovieDto>);
        }

        //GET /api/movie/1
        public IHttpActionResult GetMovie(int id)
        {
            var movie = context.Movies.SingleOrDefault(c => c.id == id);
            if (movie == null)
                return NotFound();
            return Ok(Mapper.Map<Movie, MovieDto>(movie));
        }
        //POST /api/movies
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            context.Movies.Add(movie);
            context.SaveChanges();
            movieDto.id = movie.id;
            return Created(new Uri(Request.RequestUri + "/" + movie.id), movieDto);
        }
        //PUT /api/movie/1
        [HttpPut]
        public IHttpActionResult UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var movieInDb = context.Movies.SingleOrDefault(c => c.id == id);
            if (movieInDb == null)
                return NotFound();
            Mapper.Map(movieDto, movieInDb);
            context.SaveChanges();
            return Ok();
        }
        //DELETE /api/movie/1
        [HttpDelete]
        public IHttpActionResult deleteMovie(int id)
        {
            var movie = context.Movies.SingleOrDefault(c => c.id == id);
            if (movie == null)
                return NotFound();
            context.Movies.Remove(movie);
            context.SaveChanges();
            return Ok();
        }
    }
}