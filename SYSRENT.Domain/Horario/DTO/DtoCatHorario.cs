namespace SYSRENT.Domain.Horario.DTO;

public sealed record DtoCatHorario
(
    byte IdHorario,
    string Descrip,
    byte Minutos
);
