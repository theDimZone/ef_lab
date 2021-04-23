using EF_LAb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_LAb.Manager.Interfaces
{
    public interface IMovieManager
    {
        Task<List<Movie>> GetMoviesAll();
        //Task<List<Movie>> GetMoviesByGenre();
        //Task<List<Movie>> GetMoviesBySelection();
        Task<List<Movie>> SearchMoviesByName(string query);
        Task<List<Movie>> SearchMoviesByYear(int query);

        Task<Movie> GetMovie(int Id);
        Task<Movie> GetMovieByNameAndYear(string MovieName, int MovieYear);
        Task<Movie> AddMovie(Movie movie);
        Task<Movie> RemoveMovie(int Id);
        Task<Movie> EditMovie(Movie movie);

        Task<Movie>  AddActorToMovie(Actor actor, int MovieId);
        Task<Movie> RemoveActorFromMovie(int ActorId, int MovieId);

        Task<Movie> AddGenreToMovie(Genre genre, int MovieId);
        Task<Movie> RemoveGenreFromMovie(int GenreId, int MovieId);
    }
}
