
using System.Data;
using Dapper;
using SYSRENT.Application.Contract.Persistences;
using SYSRENT.Application.Data;
using SYSRENT.Domain.Horario.DTO;

namespace SYSRENT.Infrastructure.Repository;

public class Horario(ISqlDbConnection sqlDbConnection) : IHorario
{
    private static readonly string DefaultCatalogo = "[SELECCIONAR]";
    public async Task<IEnumerable<DtoCatHorario>> ConsulCatHorario()
    {
        List<DtoCatHorario> lstDatos = [new DtoCatHorario(IdHorario: 0, Descrip: DefaultCatalogo, Minutos: 0)];

        const string SQLScript = @"SELECT IdHorario,
                                        Descrip,
                                        Minutos
                                    FROM HORARIO";
        using var Conn = sqlDbConnection.GetConnection();

        IEnumerable<DtoCatHorario> enuDatos = (await Conn.QueryAsync<DtoCatHorario>(SQLScript, null, commandType: CommandType.Text));

        lstDatos.AddRange(enuDatos);

        return lstDatos;
    }

    public Task<IEnumerable<DtoCatHorario>> ConsulHorario()
    {
        throw new NotImplementedException();
    }
}
