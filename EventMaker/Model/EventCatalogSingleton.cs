using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace EventMaker.Model
{
    public class EventCatalogSingleton
    {
        private ObservableCollection<EventMaker.Model.Event> _events;
        private static EventCatalogSingleton _instance;
        private EventCatalogSingleton()
        {
            _events = new ObservableCollection<EventMaker.Model.Event>();
            _events.Add(new Event(1,"Flamingo Møde","Dette er et møde for flamingoer", "1st lokale 145", new DateTime(2019,9,2,19,0,0)));
            _events.Add(new Event(1,"Ko Møde","Dette er et møde for Køer", "1st lokale 149", new DateTime(2020,10,2,20,15,0)));
        }

        public static EventCatalogSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                     _instance = new EventCatalogSingleton();
                }
                return _instance;
            }
        }
        public  ObservableCollection<EventMaker.Model.Event> Events
        {
            get { return _events; }
        }
        
        public void Add(EventMaker.Model.Event e)
        {
            _events.Add(e);
        }
    }
}
