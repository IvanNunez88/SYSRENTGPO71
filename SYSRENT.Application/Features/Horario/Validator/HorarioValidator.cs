using FluentValidation;
using SYSRENT.Application.Contract.Persistences;
using SYSRENT.Domain.Horario.Entity;

namespace SYSRENT.Application.Features.Horario.Validator;

public class HorarioValidator : AbstractValidator<HORARIO>
{
    private readonly IUnitOfWork _unitOfWork;

    public HorarioValidator(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;

        RuleFor(x => x.Descrip).Cascade(CascadeMode.Stop).MinimumLength(4).WithMessage("Debe escribir un horario valido");
        RuleFor(x => x.Minutos).Cascade(CascadeMode.Stop).GreaterThan(0).WithMessage("Debe escribir un numero de minutos valido");

    }
}
