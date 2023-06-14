// See https://aka.ms/new-console-template for more information
using BaalhytteBooking;

Console.WriteLine("Opgave 1");
Console.WriteLine("Test BoerneGruppe klassen");

BoerneGruppe b1 = new BoerneGruppe(1, "Mads", "Børn", 2);
BoerneGruppe b2 = new BoerneGruppe(2, "Martin", "Voksne", 10);

Console.WriteLine(b1);
Console.WriteLine(b2);
Console.WriteLine("________________________________________________________________________________________");

Console.WriteLine("Opgave 2");
Console.WriteLine("Test Rersevation klassen");

Reservation r1 = new Reservation(3, new DateTime().AddHours(6).AddMinutes(30), b1);
Reservation r2 = new Reservation(4, new DateTime().AddHours(8).AddMinutes(40), b2);

Console.WriteLine(r1);
Console.WriteLine(r2);
Console.WriteLine("________________________________________________________________________________________");

Console.WriteLine("Opgave 6");
Console.WriteLine("Test CRUD");

Reservationer rs1 = new Reservationer();
rs1.RegistrerReservation(r1);
rs1.RegistrerReservation(r2);
rs1.PrintReservationer();