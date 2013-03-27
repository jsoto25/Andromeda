using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microcolsa.Suite.Core.ConsultaInternet
{
    public partial class Archivador
    {
        /// <summary>
        /// Devuelve una enumeracion con todos los archivadores de la abse de datos.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Archivador> Consultar()
        { 
            try
            {
                IEnumerable<Archivador> Result = SuiteContext.Context.Archivadores.ToList();
                return Result;
            }
            catch (Exception Ex)
            {                
                throw Ex;
            }
        }

        /// <summary>
        /// Devuelve un archivador dependiendo de el Id pasado.
        /// </summary>
        /// <param name="Id">Id del archivador a consultar.</param>
        /// <returns></returns>
        public static Archivador Consultar(int Id)
        {
            try
            {
                List<Archivador> Subresult = SuiteContext.Context.Archivadores.Where(X => X.Id == Id).ToList();
                if (Subresult.Count > 0)
                    return Subresult.Single();
                else
                    return null;
            }
            catch (Exception Ex)
            {                
                throw Ex;
            }
        }
    }
}
