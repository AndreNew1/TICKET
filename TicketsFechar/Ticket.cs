using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketsFechar
{
    public class Ticket : Base
    {
        public long NumeroTicket { get; set; }
        public Status? Status { get; set; } 
        public string Titulo { get; set; }
        public string Mensagem { get; set; }
        [JsonIgnore]
        [ForeignKey("Usuarios")]
        public Guid? ClienteId { get; set; }
        [JsonIgnore]
        [ForeignKey("Usuarios")]
        public Guid? AtendenteId { get; set; }
        public Avaliacao? Avaliacao { get; set; }
        public List<Resposta> LstRespostas { get; set; }
    }
}
