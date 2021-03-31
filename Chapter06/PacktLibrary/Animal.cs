using System;

namespace PacktLibrary
{
    public class Animal : IDisposable
    {
        public string Name { get; set; }

        private bool isDisposed = false;

        public Animal()
        {
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed)
            {
                // deallocate resources
            }
            if (disposing)
            {
                // deallocate another resources
            }
            isDisposed = true;
        }

        public override string ToString()
        {
            return $"The {Type.GetType("this")} name is {this.Name}";
        }
    }
}
