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
        public class CEqipmentHDD
        {
            public void Start() { Console.WriteLine(this.GetType().Name + ".Start()"); }
            public void End() { Console.WriteLine(this.GetType().Name + ".End()"); }
        }

        public class CEqipmentSSD
        {
            public void Begin() { Console.WriteLine(this.GetType().Name + ".Begin()"); }
            public void Terminate() { Console.WriteLine(this.GetType().Name + ".Terminate()"); }
        }

        public class CAdapterHDD : CEqipmentHDD, IMyAppAbstract
        {
            public void Open() { this.Start(); }
            public void Close() { this.End(); }
        }

        public class CAdapterSSD : CEqipmentSSD, IMyAppAbstract
        {
            public void Open() { this.Begin(); }
            public void Close() { this.Terminate(); }
        }


        #endregion

        #region object Adapter
        public class EqipmentHDD
        {
            public void Start() { Console.WriteLine(this.GetType().Name + ".Start()"); }
            public void End() { Console.WriteLine(this.GetType().Name + ".End()"); }
        }

        public class EqipmentSSD
        {
            public void Begin() { Console.WriteLine(this.GetType().Name + ".Begin()"); }
            public void Terminate() { Console.WriteLine(this.GetType().Name + ".Terminate()"); }
        }

        public class AdapterHDD : IMyAppAbstract
        {
            private EqipmentHDD A { get; set; }

            public AdapterHDD(EqipmentHDD a)
            {
                this.A = a;
            }

            public void Open() { this.A.Start(); }
            public void Close() { this.A.End(); }
        }

        public class AdapterSSD : IMyAppAbstract
        {
            private EqipmentSSD B { get; set; }

            public AdapterSSD(EqipmentSSD a)
            {
                this.B = a;
            }

            public void Open() { this.B.Begin(); }
            public void Close() { this.B.Terminate(); }
        }
        #endregion

        static void Main(string[] args)
        {
            IMyAppAbstract adapter = new AdapterHDD(new EqipmentHDD());
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
