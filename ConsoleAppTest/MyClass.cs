using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    public class MyClass
    {
        private readonly IArg _data;

        public MyClass(IArg data)
        {
            _data = data;
        }

        public MyClass()
        {

        }

        public bool CheckArgument(string[] args)
        {
            try
            {
                return _data.CheckArgument(args);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
