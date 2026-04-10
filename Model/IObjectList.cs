using dpiotrowski_lab2.Model.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab2.Model
{
    public interface IObjectList<TElement>
    {
        public event EventHandler<TElement>? ElementAdded;
        public event EventHandler<TElement>? ElementRemoved;
        public event EventHandler<TElement>? ElementUpdated;

        public List<TElement> Elements { get; }

        public void Add(TElement element);
        public void Remove(TElement element);
        public void Update(TElement element);
    }
}
