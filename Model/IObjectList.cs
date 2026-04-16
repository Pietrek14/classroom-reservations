using dpiotrowski_lab2.Model.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab2.Model
{
    public interface IObjectList<TElement>: IReadOnlyObjectList<TElement> where TElement : IGuided
    {
        public List<TElement> Elements { get; }

        public void Add(TElement element);
        public void Remove(Guid elementId);
        public void Update(TElement element);
    }
}
