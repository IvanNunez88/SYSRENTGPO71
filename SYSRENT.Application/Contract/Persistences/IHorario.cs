using SYSRENT.Domain.Horario.DTO;

namespace SYSRENT.Application.Contract.Persistences;

public interface IHorario
{
    public Task<IEnumerable<DtoCatHorario>> ConsulCatHorario();
    public Task<IEnumerable<DtoCatHorario>> ConsulHorario();

}