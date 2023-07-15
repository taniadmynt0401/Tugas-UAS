using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
   
       public class TicketBooking
        {
            // Variabel private
            private string name;
            private string vaccinationCardNumber;
            private string nik;
            private string phoneNumber;
            private string cardNumber;

            // Property untuk mengakses dan mengubah nilai name
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            // Property untuk mengakses dan mengubah nilai vaccinationCardNumber
            public string VaccinationCardNumber
            {
                get { return vaccinationCardNumber; }
                set { vaccinationCardNumber = value; }
            }

            // Property untuk mengakses dan mengubah nilai nik
            public string NIK
            {
                get { return nik; }
                set { nik = value; }
            }

            // Property untuk mengakses dan mengubah nilai phoneNumber
            public string PhoneNumber
            {
                get { return phoneNumber; }
                set { phoneNumber = value; }
            }

            // Property untuk mengakses dan mengubah nilai cardNumber
            public string CardNumber
            {
                get { return cardNumber; }
                set { cardNumber = value; }
            }

            // Method untuk memesan tiket dan menampilkan informasi pemesanan
            public void BookTicket()
            {
                Console.WriteLine("Tiket berhasil dipesan untuk:");
                Console.WriteLine("Nama: " + name);
                Console.WriteLine("Nomor Kartu Vaksin: " + vaccinationCardNumber);
                Console.WriteLine("NIK: " + nik);
                Console.WriteLine("Nomor Telepon: " + phoneNumber);
                Console.WriteLine("Nomor Kartu: " + cardNumber);
            }
        }
    }

