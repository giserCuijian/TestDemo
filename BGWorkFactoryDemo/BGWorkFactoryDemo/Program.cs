using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BGWorkFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BGAlter bgAlter = null;

            ////使用权宗地变更
            BGFactory syqFac = new SYQFactory();
            bgAlter = syqFac.GetAlterObj();

            ////所有权宗地变更
            BGFactory suqFac = new SUQFactory();
            bgAlter = suqFac.GetAlterObj();


        }
    }
}
