﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketsFechar
{
    public class Resposta : Base
    {
        public string Mensagem { get; set; }
        [ForeignKey("Tickets")]
        public Guid? TicketId { get; set; }
        public Usuario Usuario { get; set; }
        [ForeignKey("Usuarios")]
        public Guid? UsuarioId { get; set; }
    }
}