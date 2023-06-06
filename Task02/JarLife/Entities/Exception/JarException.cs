using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarLife.Entities.Exception
{
    internal class JarException : ApplicationException
    {
        public JarException(string message) : base(message) { }
    }
}
