using EF_LAb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_LAb.Manager.Interfaces
{
    public interface IMediaManager
    {
        Task<List<Media>> GetMediaAll();
        Task<Media> GetMedia(int Id);
        Task<Media> AddMedia(Movie movie, Media media);
        Task<Media> RemoveMedia(int Id);
        Task<Media> EditMedia(Media media);
    }
}
