using System;
using reservaDeHotel.Entities.Exceptions;

namespace reservaDeHotel.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        
        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkIn > checkOut)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration ()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.Days;
        }

        public void UpdateDates (DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || CheckOut < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            if (checkIn > checkOut)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Reservation: Room {RoomNumber}, Checkin: {CheckIn.ToString("dd/MM/yyyy")}, Checkout: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights";
        }
    }
}
