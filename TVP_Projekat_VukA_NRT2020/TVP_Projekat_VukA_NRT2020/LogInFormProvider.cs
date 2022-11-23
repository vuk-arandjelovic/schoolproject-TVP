using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat_VukA_NRT2020
{
    public class LogInFormProvider
    {
        private static LogInForm LogInForma;
        public static LogInForm provide()
        {
                if (LogInForma == null)
                {
                    LogInForma = new LogInForm();
                }
                return LogInForma;
        }
        
    }
}
