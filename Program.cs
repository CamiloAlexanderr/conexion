using System;
using dbConection.Models;
using System.Linq;

namespace dbConection
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new InsideContext();
            var locos = dbContext.Locos.ToList();
            foreach(var Registro in locos){
                System.Console.WriteLine($"Id_wey: {Registro.Id}  Nombre: {Registro.Nombre}  Apellido: {Registro.Apellido}");

        }
    }
}
