using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    // interface segregation principle - good example
    public interface IWorker : IFeedable, IWorkable
    {
    }

    public interface IWorkable
    {
        public void work();
    }

    public interface IFeedable
    {
        public void eat();
    }

    public class Worker : IWorkable, IFeedable
    {
        public void work()
        {
            // ....working
        }

        public void eat()
        {
            //.... eating some lunch
        }
    }

    public class Robot : IWorkable
    {
        public void work()
        {
            // ....working and no playing
        }
    }

    public class SuperWorker : IWorkable, IFeedable
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

    public class Manager
    {
        IWorkable worker;

        public void setWorker(IWorkable w)
        {
            worker = w;
        }

        public void manage()
        {
            worker.work();
        }
    }
}
