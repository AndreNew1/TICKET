using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TicketsFechar.Data;

namespace TicketsFechar
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var nossoContext = new Context())
            {
               

                    var todossFechar = nossoContext.Tickets.Include(e => e.LstRespostas).ThenInclude(c => c.Usuario).Where(c => c.Status != Status.FECHADO).ToList();

                    todossFechar.ForEach(c => c.Status = Status.FECHADO);
                
            } 
        }
    }
}
