using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class AbstractSalesman
    {
        public List<IResourceObserver> resourceObservers;

        public AbstractSalesman()
        {
            resourceObservers = new List<IResourceObserver>();
        }

        protected void NotifyAllObservers()
        {
            foreach (IResourceObserver resource in resourceObservers)
            {
                resource.Update();
            }
        }

        public void Attach(IResourceObserver resource)
        {
            resourceObservers.Add(resource);
        }

        public void Detach(IResourceObserver resource)
        {
            resourceObservers.Remove(resource);
        }
    }
}
