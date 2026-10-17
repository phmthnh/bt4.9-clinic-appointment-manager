namespace ClinicAppointmentManager
{
    public sealed record Appointment(string Code, string PatientName, string Phone,
        DateTime AppointmentTime, string Doctor, string Reason, string Status);
}
