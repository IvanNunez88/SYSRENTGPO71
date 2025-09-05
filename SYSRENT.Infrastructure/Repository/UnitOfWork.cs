using SYSRENT.Application.Contract.Persistences;
using SYSRENT.Application.Data;

namespace SYSRENT.Infrastructure.Repository;

public class UnitOfWork(ISqlDbConnection sqlDbConnection) : IUnitOfWork
{

    private readonly ISqlDbConnection _sqlDbConnection = sqlDbConnection;

}
