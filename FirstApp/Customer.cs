using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp
{
    public class Customer : Person 
    {
        //some code here

        public override string GetJobSummary()
        {
            return "buy goods";
        }
    }
}
