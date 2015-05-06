using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipleBad
{

    // interface segregation principle - bad example
    public interface IWorker
    {
        public void work();
        public void eat();
    }

    //Normal Worker
    public class Worker : IWorker
    {
        public void work()
        {
            // ....working
        }
        public void eat()
        {
            // ...... eating some lunch
        }
    }

    //Super Worker
    public class SuperWorker : IWorker
    {
        public void work()
        {
            //.... working much more
        }

        public void eat()
        {
            //.... eating some lunch
        }
    }

    //Robot Worker
    public class RobotWorker : IWorker
    {
        public void work()
        {
            //.... tireless work
        }

        public void eat() //Not Good
        {
            //.... nuts and bolts???
        }
    }

    public class Manager
    {
        public IWorker worker;

        public void setWorker(IWorker w)
        {
            worker = w;
        }

        public void manage()
        {
            worker.work();
        }
    }
}
