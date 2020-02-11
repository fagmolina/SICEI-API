using Oracle.ManagedDataAccess.Client;
using Ponal.Dinae.Estic.Sicei.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ponal.Dinae.Estic.Sicei.DataAccess.Base
{
    public  class BaseRepository
    {

        String Con = @"DATA SOURCE=localhost:1521/GLOBAL;PASSWORD=sicei123;USER ID=sicei";
        protected IEnumerable<T> EjecutarProcedure<T>(ProcedimientoParametroDTO param)
        {
            #region Validation Params
            if (param == null) throw new ArgumentNullException("param");
            #endregion

            var esquema = (ConfigurationManager.AppSettings["Esquema"] ?? "sicei");
            StringBuilder query = new StringBuilder();
            query.AppendFormat("BEGIN  {0}.{1}({2}); END;", esquema, param.NombreProcedimiento, string.Join(",", param.ArregloParametros.Select(w => w.Nombre)));
            OracleParameter[] arrayParametros = new OracleParameter[param.ArregloParametros.Count];

            for (int index = 0; index < param.ArregloParametros.Count; index++)
            {
                var item = param.ArregloParametros[index];
                OracleParameter parametroProcedimiento = new OracleParameter();

                try
                {
                    parametroProcedimiento.ParameterName = item.Nombre;
                    parametroProcedimiento.Direction = (ParameterDirection)Enum.Parse(typeof(ParameterDirection), item.Direccion);
                    parametroProcedimiento.OracleDbType = (OracleDbType)Enum.Parse(typeof(OracleDbType), item.Tipo);
                    parametroProcedimiento.Value = item.Valor;
                    parametroProcedimiento.Size = item.Longitud;
                    arrayParametros[index] = parametroProcedimiento;
                }
                catch (Exception)
                {
                    parametroProcedimiento.Dispose();
                    throw;
                }
            }


            // Crea cursores
            IEnumerable<T> c1 = new List<T>();

            // Conexión por ADO
            using (OracleConnection conn = new OracleConnection(Con))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText = query.ToString()
                };
                cmd.Parameters.AddRange(arrayParametros);

                using (OracleDataReader dr = cmd.ExecuteReader())
                {

                    c1 = DataReaderMapToList<T>(dr); // Mapea el resultado de la query al Dto pasado como T
                    //dr.NextResult(); //Lee el siguiente cursor
                    //c2 = DataReaderMapToList<U>(dr); // Mapea el resultado de la query al Dto pasado como U                 
                }

            }

            foreach (OracleParameter op in arrayParametros)
            {
                for (int index = 0; index < param.ArregloParametros.Count; index++)
                {
                    var item = param.ArregloParametros[index];
                    if (op.ParameterName == item.Nombre)
                    {
                        item.Valor = (object)op.Value;
                    }

                    param.ArregloParametros[index] = item;

                }
            }

            return c1;

        }



        /// <summary>
        /// Mapea el resultado de ExecuteReader al Dto pasado
        /// </summary>
        /// <typeparam name="T"> Dto al que se necesita castear/mapear</typeparam>
        /// <param name="dr"></param>
        /// <returns></returns>
        private static IEnumerable<T> DataReaderMapToList<T>(IDataReader dr)
        {
            List<T> list = new List<T>();
            T obj = default(T);
            while (dr.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!object.Equals(dr[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, dr[prop.Name], null);
                    }
                }
                list.Add(obj);
            }
            return list;
        }
    }
}
