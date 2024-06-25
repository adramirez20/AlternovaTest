namespace MedicalWebAPI.Domain.Entities
{
    public class Cita
    {
        public int CitaId { get; set; }
        public int UsuarioId { get; set; }
        public int DoctorId { get; set; }
        public int ConsultorioId { get; set; }
        public DateTime FechaCita { get; set; }
        public Usuario Usuario { get; set; }
        public Doctor Doctor { get; set; }
        public Consultorio Consultorio { get; set; }
    }
}
