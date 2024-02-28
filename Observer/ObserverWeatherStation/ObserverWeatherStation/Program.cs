using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverWeatherStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            weatherStation weatherStation = new weatherStation();
            newsAgency agency1 =new newsAgency("alpha");
            weatherStation.Attach(agency1);
            newsAgency agency2= new newsAgency("omega");
            weatherStation.Attach(agency2);

            weatherStation.Temperature = 32.09f;
            weatherStation.Temperature = 3.09f;
            weatherStation.Temperature = 2.09f;
            weatherStation.Temperature = 92.09f;
            Console.ReadLine();
        }
    }
    interface ISubject
    {
        void Attach(IObserver observer);
        void Notify(); 
    }

    class weatherStation : ISubject
    {
        private List<IObserver> observers;
        public float Temperature { get { return _Temperature; }
            set { _Temperature = value;
                Notify();
            }
        }
        private float _Temperature { get; set; }
        public weatherStation()
        {
                observers = new List<IObserver>();

        }

        public void Attach(IObserver observer)
        {
           observers.Add(observer);
        }

        public void Notify()
        {
            observers.ForEach (o =>
            {
                o.Update(this);
            }) ;
        }
    }
    interface IObserver {
        void Update(ISubject subject);
    }
    class newsAgency : IObserver
    {
        public string AgencyName { get; set; }
        public newsAgency(string name)
        {
            AgencyName = name;
        }

        public void Update(ISubject subject)
        {
           weatherStation weatherStation =subject as weatherStation;
            if (weatherStation != null) { 
                Console.WriteLine(String.Format("{0} reporting tempreature {1}", AgencyName,weatherStation.Temperature));
                Console.WriteLine();
            }
        }
    }
}
