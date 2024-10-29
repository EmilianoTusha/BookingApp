using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Application.Common
{
    //te gjitha hapat e nje veprimi ruhen ne nje transaksion te vetem
    public interface IUnitOfWork
    {
        IArtistRepository ArtistRepository { get; } 
        IBookingRepository BookingRepository { get; }
        IConcertRepository ConcertRepository { get; }
        ITicketRepository TicketRepository { get; }
        IVenueRepository VenueRepository { get; }
        void Save();

    }
}
