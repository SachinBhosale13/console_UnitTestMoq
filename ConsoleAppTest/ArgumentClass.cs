using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    public interface IArg
    {
        bool CheckArgument(string[] args);
    }
    public class ArgumentClass:IArg
    {
        public bool CheckArgument(string[] args)
        {
            bool result = false;

            if (args.Count() > 0)
            {
                result = true;
            }
            return result;
        }
    }
}
