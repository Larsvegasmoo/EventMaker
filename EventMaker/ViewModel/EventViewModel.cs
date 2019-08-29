using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker.Model;

namespace EventMaker.ViewModel
{
    public class EventViewModel
    {
        private EventCatalogSingleton _catalog;

        public EventViewModel()
        {
            _catalog = EventCatalogSingleton.Instance;
        }
        public EventCatalogSingleton Catalog
        {
            get { return _catalog; }
        }
    }
}
