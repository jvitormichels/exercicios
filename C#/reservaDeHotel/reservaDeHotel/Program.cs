using System;
using reservaDeHotel.Entities;
using reservaDeHotel.Entities.Exceptions;

namespace reservaDeHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in date: ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date: ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation r = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine(r);

                Console.WriteLine("\nEnter data to update the reservation: ");
                Console.Write("Check-in date: ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date: ");
                checkOut = DateTime.Parse(Console.ReadLine());
                r.UpdateDates(checkIn, checkOut);
                Console.WriteLine(r);
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error! " + e.Message);
            }
        }
    }
}
