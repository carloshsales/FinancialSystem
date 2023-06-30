
using Domain.Interfaces.Generics;
using Infra.Configs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace Infra.Repositories.Generics
{
    public class GenericRepository<T> : IGeneric<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<BaseContext> _optionsBuilder;

        public GenericRepository ()
        {
            _optionsBuilder = new DbContextOptions<BaseContext>();
        }

        #region CRUD
        public async Task Add ( T obj )
        {
            using (var data = new BaseContext( _optionsBuilder ))
            {
                await data.Set<T>().AddAsync( obj );
                await data.SaveChangesAsync();
            }
        }

        public async Task Delete ( T obj )
        {
            using (var data = new BaseContext( _optionsBuilder ))
            {
                data.Set<T>().Remove( obj );
                await data.SaveChangesAsync();
            }
        }

        public async Task<List<T>> GetAll ()
        {
            using (var data = new BaseContext( _optionsBuilder ))
            {
                return await data.Set<T>().ToListAsync();
            }
        }

        public async Task<T> GetById ( int id )
        {
            using (var data = new BaseContext( _optionsBuilder ))
            {
                return await data.Set<T>().FindAsync( id );
            }
        }

        public async Task Update ( T obj )
        {
            using (var data = new BaseContext( _optionsBuilder ))
            {
                data.Set<T>().Update( obj );
                await data.SaveChangesAsync();
            }
        }
        #endregion

        #region Disposed

        bool disposed = false;
        SafeHandle handle = new SafeFileHandle( IntPtr.Zero, true );
        public void Dispose ()
        {
            Dispose( true );
            GC.SuppressFinalize( this );
        }

        protected virtual void Dispose ( bool disposing )
        {
            if (disposed) return;
            if (disposing) handle.Dispose();
            disposed = true;
        }

        #endregion
    }
}
