using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sairi.ModuloAsistencia.DataContract;
using Sairi.ModuloAsistencia.DataBase;

namespace Sairi.ModuloAsistencia.DataAccess
{
    public class AsistenciaEstudianteDA : IAsistenciaEstudianteDA
    {
        private readonly SairiContext db = new SairiContext();
        public IEnumerable<AsistenciaEstudianteResponse> ListAsistenciaEstudiante()
        {
            var result = new List<AsistenciaEstudianteResponse>();

            try
            {
                using (var ctx = db)
                {
                    result = (
                       
                        from d in ctx.Estudiante
                        from a in ctx.AsistenciaEstudiante.Where(x => x.id_estudiante == d.id).DefaultIfEmpty()
                        select new AsistenciaEstudianteResponse
                        {
                            //id=a.id,
                            //dni=d.dni,
                            //nombres=d.nombres,
                            //apellidos=d.apellidos,
                            //codigo=d.codigo,
                            //hora_ingreso=a.hora_ingreso,
                            //hora_salida=a.hora_salida,
                            //fecha=a.fecha
                            id=a.id,
                            id_estudiante=a.id_estudiante,
                            id_nivel=d.id_nivel,
                            nombres = d.nombres,
                            apellidos = d.apellidos,
                            dni = d.dni,
                            codigo = d.codigo,
                            hora_ingreso =a.hora_ingreso,
                            hora_salida=a.hora_salida,
                            fecha=a.fecha
                            
                        }

                        ).Where(x=>x.id_nivel==2).OrderByDescending(c => c.fecha).ToList();
                }

                return result;
            }
            finally
            {
                db.Dispose();
            }
        }
    }
}
