using System.Diagnostics.Contracts;
using SYSRENT.Domain.Horario.DTO;
using SYSRENT.Domain.Horario.Entity;

namespace SYSRENT.Application.Contract.Persistences;

public interface IHorarioRepository
{
    public Task<IEnumerable<DtoCatHorario>> ConsulCatHorario();
    public Task<IEnumerable<DtoCatHorario>> ConsulHorario();
    public Task<bool> AgregarHorario(HORARIO Horario);
}