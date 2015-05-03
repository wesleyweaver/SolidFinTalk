using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public interface IStarter_Good
    {
        string Brand { get; set; }
        string Model { get; set; }
        IgnitionResult Start();
    }

    public interface IElectricStarter_Good : IStarter_Good
    {
        Battery Battery { get; set; }
    }

    public interface IPneumaticStarter_Good : IStarter_Good
    {
        AirCompressor Compressor { get; set; }
    }

    public interface IHydraulicStarter_Good : IStarter_Good
    {
        HydraulicPump Pump { get; set; }
    }

    public class ElectricStarter_Good : IElectricStarter_Good
    {
        public string Brand
        {
            get;
            set;
        }

        public string Model
        {
            get;
            set;
        }

        public Battery Battery
        {
            get;
            set;
        }

        public IgnitionResult Start()
        {
            //code here to initiate the electric starter
            return IgnitionResult.Success;
        }
    }

    public class PneumaticStarter_Good : IPneumaticStarter_Good
    {
        public string Brand
        {
            get;
            set;
        }

        public string Model
        {
            get;
            set;
        }

        public AirCompressor Compressor
        {
            get;
            set;
        }

        public IgnitionResult Start()
        {
            //code here to initiate the pneumatic starter
            return IgnitionResult.Success;
        }
    }

    public class HydraulicStarter_Good : IHydraulicStarter_Good
    {
        public string Brand
        {
            get;
            set;
        }

        public string Model
        {
            get;
            set;
        }

        public HydraulicPump Pump
        {
            get;
            set;
        }

        public IgnitionResult Start()
        {
            //code here to initiate the hydraulic starter
            return IgnitionResult.Success;
        }
    }
}
