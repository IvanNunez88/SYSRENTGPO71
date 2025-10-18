using MediatR;
using SYSRENT.Application.Contract.Persistences;
using SYSRENT.Application.Features.Horario.Validator;
using SYSRENT.Domain;
using SYSRENT.Domain.Horario.Entity;

namespace SYSRENT.Application.Features.Horario.Command;
#region Command

public record AddHorarioCommand(HORARIO Horario) : IRequest<DtoResponse<IEnumerable<bool>>>;

#endregion

#region Handler

public class AddHorarioCommandHandler(IUnitOfWork _unitOfWork) : IRequestHandler<AddHorarioCommand, DtoResponse<IEnumerable<bool>>>
{
    public async Task<DtoResponse<IEnumerable<bool>>> Handle(AddHorarioCommand request, CancellationToken cancellationToken)
    {
        DtoResponse<IEnumerable<bool>> rsp = new();
        HorarioValidator Validaciones = new(_unitOfWork);

        var validationResult = await Validaciones.ValidateAsync(request.Horario, cancellationToken);
        IEnumerable<string>? enuResultado = validationResult.Errors.Select(x => x.ErrorMessage);


        if (!enuResultado.Any())
        {
            if (await _unitOfWork.HorarioRepository.AgregarHorario(request.Horario))
            {
                rsp.Status = true;
            }
            else
            {
                rsp.Status = false;
            }
        }
        else
        {
            rsp.Status = false;
            rsp.Msg = enuResultado.ToList()[0];
        }

        return rsp;
    }
}

#endregion

