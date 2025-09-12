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
    public async Task<DtoResponse<IEnumerable<DtoCatHorario>>> Handle(GetCatHorarioQuery request, CancellationToken cancellationToken)
    {
        IEnumerable<DtoCatHorario> enuDatos = await _unitOfWork.HorarioRepository.ConsulCatHorario();
        DtoResponse<IEnumerable<DtoCatHorario>> rsp = new();

        if (enuDatos.Any())
        {
            rsp.Status = true;
            rsp.Value = enuDatos;
        }
        else
        {
            rsp.Status = false;
            rsp.Msg = "No se encontro información";
        }
        return rsp;

    }
}


#endregion



// public async Task<DtoResponse<IEnumerable<DtoCatHorario>>> Handler(GetCatHorarioQuery request, CancellationToken cancellationToken)
//     {
//         IEnumerable<DtoCatHorario> enuDatos = await _unitOfWork.HorarioRepository.ConsulCatHorario();
//         DtoResponse<IEnumerable<DtoCatHorario>> rsp = new();

//         if (enuDatos.Any())
//         {
//             rsp.Status = true;
//             rsp.Value = enuDatos;
//         }
//         else
//         {
//             rsp.Status = false;
//             rsp.Msg = "No se encontro información";
//         }

//     }