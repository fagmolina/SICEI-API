using Ponal.Dinae.Estic.Sicei.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponal.Dinae.Estic.Sicei.DataAccess.Base
{
    public class UOW : IDisposable
    {

        private UnidadRepository _unidadRepository;
        private UsuarioRepository _usuarioRepository;
        private AreaRepository _areaRepository;
        private AreaLineaRepository _areaLineaRepository;
        private GradoRepository _gradoRepository;
        private InvestigacionRepository _investigacionRepository;

        public InvestigacionRepository InvestigacionRepository
        {
            get
            {
                if (_investigacionRepository == null)
                {
                    _investigacionRepository = new InvestigacionRepository();
                }
                return _investigacionRepository;
            }
        }

        public UnidadRepository Unidadrepository
        {
            get
            {
                if (_unidadRepository == null)
                {
                    _unidadRepository = new UnidadRepository();
                }
                return _unidadRepository;
            }
        }


        public UsuarioRepository UsuarioRepository
        {
            get
            {
                if (_usuarioRepository == null)
                {
                    _usuarioRepository = new UsuarioRepository();
                }
                return _usuarioRepository;
            }
        }

        public AreaRepository AreaRepository
        {
            get
            {
                if (_areaRepository == null)
                {
                    _areaRepository = new AreaRepository();
                }
                return _areaRepository;
            }
        }

        public AreaLineaRepository AreaLineaRepository
        {
            get
            {
                if (_areaLineaRepository == null)
                {
                    _areaLineaRepository = new AreaLineaRepository();
                }
                return _areaLineaRepository;
            }
        }


        public GradoRepository GradoRepository
        {
            get
            {
                if (_gradoRepository == null)
                {
                    _gradoRepository = new GradoRepository();
                }
                return _gradoRepository;
            }
        }


        #region IDisposable Support  
        private bool _disposedValue = false; // To detect redundant calls  

        protected virtual void Dispose(bool disposing)
        {
            if (_disposedValue) return;

            if (disposing)
            {
                //dispose managed state (managed objects).  
            }

            // free unmanaged resources (unmanaged objects) and override a finalizer below.  
            // set large fields to null.  

            _disposedValue = true;
        }

        // override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.  
        // ~UnitOfWork() {  
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.  
        //   Dispose(false);  
        // }  

        // This code added to correctly implement the disposable pattern.  
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.  
            Dispose(true);
            // uncomment the following line if the finalizer is overridden above.  
            // GC.SuppressFinalize(this);  
        }
        #endregion
    }
}
