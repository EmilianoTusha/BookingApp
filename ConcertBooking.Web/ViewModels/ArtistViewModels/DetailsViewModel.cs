using System;

namespace ConcertBooking.Web.ViewModels.ArtistViewModels
{
    public class ArtistDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Bio { get; set; }
        public string? ImageUrl { get; set; }
    }
}
