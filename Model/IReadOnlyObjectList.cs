using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace dpiotrowski_lab2.Model
{
    public interface IReadOnlyObjectList<out TElement> where TElement : IGuided
    {
        public event EventHandler<TElement>? ElementAdded;
        public event EventHandler<TElement>? ElementRemoved;
        public event EventHandler<TElement>? ElementUpdated;

        public TElement Get(Guid elementId);
    }
}
