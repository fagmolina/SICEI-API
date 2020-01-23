using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ponal.Dinae.Estic.Sicei.Common;
using Ponal.Dinae.Estic.Sicei.Common.Enums;

namespace Ponal.Dinae.Estic.Sicei.Entities.DTO
{
    public class ProcedimientoParametroDTO
    {
        #region Variables

        public string NombreProcedimiento { get; set; }
        private List<ParametroDTO> arregloParametros;

        #endregion

        #region Constructor

        public ProcedimientoParametroDTO()
        {
            arregloParametros = new List<ParametroDTO>();
        }

        #endregion

        #region Métodos

        public void AdicionarParametro(string nombre, object valor)
        {
            ParametroDTO parametro = new ParametroDTO();
            parametro.Nombre = nombre;
            parametro.Direccion = DireccionParametro.Input.ToString();
            parametro.Tipo = TipoParametro.Varchar2.ToString();
            parametro.Valor = valor;
            arregloParametros.Add(parametro);
        }

        public void AdicionarParametro(string nombre, object valor, DireccionParametro direccion, TipoParametro tipo)
        {
            ParametroDTO parametro = new ParametroDTO();
            parametro.Nombre = nombre;
            parametro.Direccion = direccion.ToString();
            parametro.Tipo = tipo.ToString();
            parametro.Valor = valor;
            arregloParametros.Add(parametro);
        }

        public void AdicionarParametro(string nombre, object valor, DireccionParametro direccion, TipoParametro tipo, int longitud)
        {
            ParametroDTO parametro = new ParametroDTO();
            parametro.Nombre = nombre;
            parametro.Direccion = direccion.ToString();
            parametro.Tipo = tipo.ToString();
            parametro.Valor = valor;
            parametro.Longitud = longitud;
            arregloParametros.Add(parametro);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        public List<ParametroDTO> ArregloParametros
        {
            get
            {
                return arregloParametros;
            }
        }

        #endregion
    }
}
