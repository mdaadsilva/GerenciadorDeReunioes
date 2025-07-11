using System;

namespace Reunioes.API.DTOs
{
    public class CriarReservaDto
    {
        public required DateTime Inicio { get; set; }
        public required DateTime Fim { get; set; }
        public required int SalaId { get; set; }
    }
}