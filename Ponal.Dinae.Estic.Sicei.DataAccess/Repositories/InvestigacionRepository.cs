using Ponal.Dinae.Estic.Sicei.Common.Enums;
using Ponal.Dinae.Estic.Sicei.DataAccess.Base;
using Ponal.Dinae.Estic.Sicei.Entities.DTO;
using Ponal.Dinae.Estic.Sicei.Entities.InvInstitucional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponal.Dinae.Estic.Sicei.DataAccess.Repositories
{
    public class InvestigacionRepository : BaseRepository
    {
        public IEnumerable<InvestigacionDTO> ConsultarInvestigaciones()
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS.prc_get_investigacion";


            parametro.AdicionarParametro(":P_RESULTADO", null, DireccionParametro.Output, TipoParametro.RefCursor);

            var respuesta = EjecutarProcedure<InvestigacionDTO>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;
        }

        public Tuple<string,string> MergeInvestigacion(InvInstitucional investigacion)
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS.prc_merge_investigacion";

            parametro.AdicionarParametro(":p_id_investigacion", investigacion.IdInvestigacion, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_titulo", investigacion.Titulo, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_direccion", investigacion.Direccion, DireccionParametro.Input, TipoParametro.Decimal);
            parametro.AdicionarParametro(":p_ano", investigacion.Anio, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_participacion", investigacion.Participacion, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_exp_participa", investigacion.ExParticipa, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_escuela", investigacion.Escuela, DireccionParametro.Input, TipoParametro.Decimal);
            parametro.AdicionarParametro(":p_mensaje", null, DireccionParametro.Output, TipoParametro.RefCursor);

            var respuesta = EjecutarProcedure<ResultInvInstitucionalDTO>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return new Tuple<string, string>(respuesta.Single().codigo, respuesta.Single().mensaje);
        }


        public IEnumerable<Object> MergeAreaLineaInv(AreaLinea area, string id)
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS.prc_merge_area_linea_inv";
            parametro.AdicionarParametro(":p_id_investigacion", id, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_id_area", area.IdArea, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_id_linea", area.IdLinea, DireccionParametro.Input, TipoParametro.Decimal);
            parametro.AdicionarParametro(":p_mensaje", null, DireccionParametro.Output, TipoParametro.RefCursor);

            var respuesta = EjecutarProcedure<ResultDTO>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;
        }

        public IEnumerable<Object> MergeInvestigadoresInv(Investigarores investigador , string id)
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS.prc_merge_investigadores_inv";
            parametro.AdicionarParametro(":p_id_investigacion", id, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_id_investigador", investigador.IdInvestigador, DireccionParametro.Input, TipoParametro.Int32);
            parametro.AdicionarParametro(":p_mensaje", null, DireccionParametro.Output, TipoParametro.RefCursor);

            var respuesta = EjecutarProcedure<ResultDTO>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;
        }


        public IEnumerable<Object> MergeProductoInv(Producto producto, string id)
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS.prc_merge_producto_inv";
            parametro.AdicionarParametro(":p_id_investigacion", id, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_tipo_producto", producto.TipoProducto, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_autor", producto.Autor, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_nombre_revista", producto.NombreRevista, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_nombre_articulo", producto.NombreArticulo, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_ano", producto.Anio, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_codigo_issn", producto.CodigoISSN, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_codigo_isbn", "", DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_nombre_libro", producto.NombreLibro, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_pagina_inicio", producto.PaginaInicio, DireccionParametro.Input, TipoParametro.Int32);
            parametro.AdicionarParametro(":p_pagina_final", producto.PaginaFinal, DireccionParametro.Input, TipoParametro.Int32);
            parametro.AdicionarParametro(":p_editorial", producto.Editorial, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_fecha_publicacion", producto.FechaPublicacion, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_mensaje", null, DireccionParametro.Output, TipoParametro.RefCursor);
            var respuesta = EjecutarProcedure<ResultDTO>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;
        }


        public IEnumerable<Object> MergeEstimulosInv(Estimulos estimulo, string id)
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS.prc_merge_estimulos_inv";
            parametro.AdicionarParametro(":p_id_investigacion", id, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_condecoraciones", estimulo.Condecoraciones, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_felicitaciones", estimulo.Felicitaciones, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_personaje_mes", estimulo.PersonajeMes, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_permiso", estimulo.Permiso, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_estatuillas", estimulo.Estatuillas, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_monedas", estimulo.Monedas, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_capacitaciones", estimulo.Capacitaciones, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_mensaje", null, DireccionParametro.Output, TipoParametro.RefCursor);

            var respuesta = EjecutarProcedure<ResultDTO>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;
        }



        public IEnumerable<Object> MergeEventosInv(Eventos evento, string id)
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS.prc_merge_eventos_inv";
            parametro.AdicionarParametro(":p_id_investigacion", id, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_tipo", evento.Tipo, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_participacion", evento.Participacion, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_fecha", evento.Fecha, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_tipo_region", evento.TipoRegion, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_desc_region", evento.DescRegion, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_desc_subregion", evento.DescSubRegion, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_mensaje", null, DireccionParametro.Output, TipoParametro.RefCursor);

            var respuesta = EjecutarProcedure<ResultDTO>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;
        }


        public IEnumerable<Object> MergePresupuestoInv(Presupuesto presupuesto, string id)
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS.prc_merge_presup_investigacion";
            parametro.AdicionarParametro(":p_id_investigacion", id, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_nombre_presupuesto", presupuesto.NombrePresupuesto, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_desc_presupuesto", presupuesto.DescPresupuesto, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_aporte", presupuesto.Aporte, DireccionParametro.Input, TipoParametro.Int32);            
            parametro.AdicionarParametro(":p_mensaje", null, DireccionParametro.Output, TipoParametro.RefCursor);

            var respuesta = EjecutarProcedure<ResultDTO>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;
        }

        public IEnumerable<InvestigadorDTO> ConsultarInvestigadores()
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS.prc_get_investigador";


            parametro.AdicionarParametro(":p_resultado", null, DireccionParametro.Output, TipoParametro.RefCursor);

            var respuesta = EjecutarProcedure<InvestigadorDTO>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;
        }

    }
}
