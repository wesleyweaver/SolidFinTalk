using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public interface IStarter_Bad
    {
        string Brand { get; set; }
        string Model { get; set; }
        Battery Battery { get; set; }
        AirCompressor Compressor { get; set; }
        HydraulicPump Pump { get; set; }
        IgnitionResult Start();
    }

    public class ElectricStarter_Bad : IStarter_Bad
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

        public AirCompressor Compressor
        {
            get
            {
                throw new NotImplementedException("An Electric Starter does not use an AirCompressor.");
            }
            set
            {
                throw new NotImplementedException("An Electric Starter does not use an AirCompressor.");
            }
        }

        public HydraulicPump Pump
        {
            get
            {
                throw new NotImplementedException("An Electric Starter does not use a HydraulicPump.");
            }
            set
            {
                throw new NotImplementedException("An Electric Starter does not use an HydraulicPump.");
            }
        }

        public IgnitionResult Start()
        {
            //code here to initiate the electric starter
            return IgnitionResult.Success;
        }
    }

    public class PneumaticStarter_Bad : IStarter_Bad
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
            get
            {
                throw new NotImplementedException("An PneumaticStarter does not use a Battery.");
            }
            set
            {
                throw new NotImplementedException("An PneumaticStarter does not use an Battery.");
            }
        }

        public AirCompressor Compressor
        {
            get;
            set;
        }

        public HydraulicPump Pump
        {
            get
            {
                throw new NotImplementedException("An PneumaticStarter does not use a HydraulicPump.");
            }
            set
            {
                throw new NotImplementedException("An PneumaticStarter does not use an HydraulicPump.");
            }
        }

        public IgnitionResult Start()
        {
            //code here to initiate the pneumatic starter
            return IgnitionResult.Success;
        }
    }

    public class HydraulicStarter_Bad : IStarter_Bad
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
            get
            {
                throw new NotImplementedException("A HydraulicStarter does not use a Battery.");
            }
            set
            {
                throw new NotImplementedException("A HydraulicStarter does not use an Battery.");
            }
        }

        public AirCompressor Compressor
        {
            get
            {
                throw new NotImplementedException("A HydraulicStarter does not use an AirCompressor.");
            }
            set
            {
                throw new NotImplementedException("A HydraulicStarter does not use an AirCompressor.");
            }
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

    public class Battery
    {
    }

    public class AirCompressor
    {
    }

    public class HydraulicPump
    {
    }

    public enum IgnitionResult
    {
        Success,
        Failure
    }
}
