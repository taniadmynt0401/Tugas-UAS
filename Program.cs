using Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek TicketBooking
            TicketBooking ticketBooking = new TicketBooking();

            // Meminta pengguna untuk memasukkan informasi pemesanan tiket
            Console.Write("Masukkan Nama: ");
            string name = Console.ReadLine();
            Console.Write("Masukkan Nomor Kartu Vaksin: ");
            string vaccinationCardNumber = Console.ReadLine();
            Console.Write("Masukkan NIK: ");
            string nik = Console.ReadLine();
            Console.Write("Masukkan Nomor Telepon: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Masukkan Nomor Kartu: ");
            string cardNumber = Console.ReadLine();

            // Mengatur nilai property menggunakan setter
            ticketBooking.Name = name;
            ticketBooking.VaccinationCardNumber = vaccinationCardNumber;
            ticketBooking.NIK = nik;
            ticketBooking.PhoneNumber = phoneNumber;
            ticketBooking.CardNumber = cardNumber;

            // Memanggil method BookTicket untuk memesan tiket
            ticketBooking.BookTicket();
        }
    }
}