using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sairi.ModuloAsistencia.DataContract;
using Sairi.ModuloAsistencia.DataBase;
using System.Data.SqlClient;

namespace Sairi.ModuloAsistencia.DataAccess
{
    public class AsistenciaDocenteDA : IAsistenciaDocenteDA
    {
        private readonly SairiContext db = new SairiContext();
        public IEnumerable<AsistenciaDocenteResponse> ListAsistenciaDocente()
        {



            var result = new List<AsistenciaDocenteResponse>();

            try
            {
                using (var ctx = db)
                {
                    result = (
                        from d in ctx.Docente
                        from a in ctx.AsistenciaDocente.Where(x => x.id_docente == d.id).DefaultIfEmpty()
                        select new AsistenciaDocenteResponse
                        {

                            id = a.id,
                            id_docente = a.id_docente,
                            nombres=d.nombres,
                            apellidos=d.apellidos,
                            dni=d.dni,
                            codigo=d.codigo,
                            hora_ingreso = a.hora_ingreso,
                            hora_salida = a.hora_salida,
                            fecha = a.fecha

                        }

                        ).OrderByDescending(c => c.fecha).ToList();

                }

                return result;
            }
            finally
            {
                db.Dispose();
            }

        }

        //public IEnumerable<AsistenciaDocenteResponse> ListAsistenciaDocenteByFecha(string fecha)
        //{
        //    var result = new List<AsistenciaDocenteResponse>();

        //    try
        //    {
        //        using (var ctx = db)
        //        {
        //            result = (
        //                from d in ctx.Docente
        //                from a in ctx.AsistenciaDocente.Where(x => x.id_docente == d.id).DefaultIfEmpty()
        //                select new AsistenciaDocenteResponse
        //                {
        //                    id = a.id,
        //                    dni = d.dni,
        //                    nombres = d.nombres,
        //                    apellidos = d.apellidos,
        //                    codigo = d.codigo,
        //                    hora_ingreso = a.hora_ingreso,
        //                    hora_salida = a.hora_salida,
        //                    fecha = a.fecha

        //                }

        //                ).Where(c=>c.fecha==fecha).OrderByDescending(c => c.fecha).ToList();
        //        }

        //        return result;
        //    }
        //    finally
        //    {
        //        db.Dispose();
        //    }
        //}
    }
}
