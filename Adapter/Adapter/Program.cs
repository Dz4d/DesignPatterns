using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {

        public interface IMyAppAbstract
        {
            void Open();
            void Close();
        }

        #region class Adapter
        public class ICEqipmentHDD
        {
            public void Start() { Console.WriteLine(this.GetType().Name + ".Start()"); }
            public void End() { Console.WriteLine(this.GetType().Name + ".End()"); }
        }

        public class ICEqipmentSSD
        {
            public void Begin() { Console.WriteLine(this.GetType().Name + ".Begin()"); }
            public void Terminate() { Console.WriteLine(this.GetType().Name + ".Terminate()"); }
        }

        public class CAdapterHDD : ICEqipmentHDD, IMyAppAbstract
        {
            public void Open() { this.Start(); }
            public void Close() { this.End(); }
        }

        public class CAdapterSSD : ICEqipmentSSD, IMyAppAbstract
        {
            public void Open() { this.Begin(); }
            public void Close() { this.Terminate(); }
        }


        #endregion

        #region object Adapter
        public class IEqipmentHDD
        {
            public void Start() { Console.WriteLine(this.GetType().Name + ".Start()"); }
            public void End() { Console.WriteLine(this.GetType().Name + ".End()"); }
        }

        public class IEqipmentSSD
        {
            public void Begin() { Console.WriteLine(this.GetType().Name + ".Begin()"); }
            public void Terminate() { Console.WriteLine(this.GetType().Name + ".Terminate()"); }
        }

        public class AdapterHDD : IMyAppAbstract
        {
            private IEqipmentHDD A { get; set; }

            public AdapterHDD(IEqipmentHDD a)
            {
                this.A = a;
            }

            public void Open() { this.A.Start(); }
            public void Close() { this.A.End(); }
        }

        public class AdapterSSD : IMyAppAbstract
        {
            private IEqipmentSSD B { get; set; }

            public AdapterSSD(IEqipmentSSD a)
            {
                this.B = a;
            }

            public void Open() { this.B.Begin(); }
            public void Close() { this.B.Terminate(); }
        }
        #endregion

        static void Main(string[] args)
        {
            IMyAppAbstract adapter = new AdapterHDD(new IEqipmentHDD());
            adapter.Open();
            adapter.Close();

            IMyAppAbstract classAdapter = new CAdapterSSD();
            classAdapter.Open();
            classAdapter.Close();
            Console.ReadKey();

            //powiazane wzorce: 
            //Most 
            //Dekorator
            //Pełnomocnik
        }
    }
}
