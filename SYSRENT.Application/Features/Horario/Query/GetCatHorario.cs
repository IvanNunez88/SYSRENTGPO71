using MediatR;
using SYSRENT.Application.Contract.Persistences;
using SYSRENT.Domain;
using SYSRENT.Domain.Horario.DTO;

namespace SYSRENT.Application.Features.Horario.Query;

#region Query
public record GetCatHorarioQuery() : IRequest<DtoResponse<IEnumerable<DtoCatHorario>>>;

#endregion

#region Handler

public class GetCatHorarioQueryHandler(IUnitOfWork _unitOfWork) : IRequestHandler<GetCatHorarioQuery, DtoResponse<IEnumerable<DtoCatHorario>>>
{
    public Task<DtoResponse<IEnumerable<DtoCatHorario>>> Handle(GetCatHorarioQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

#endregion