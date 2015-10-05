using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyFactory
{
    public interface IToy
    {
        public void MakeSound();
        public void start();
        public void stop();
    }
}
