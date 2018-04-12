using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BGWorkFactoryDemo
{
    /// <summary>
    /// 变更对象
    /// </summary>
    public abstract class BGAlter
    {
        public abstract void DoNum();
    }

    /// <summary>
    /// 使用权宗地变更
    /// </summary>
    public class SYQBGAlter : BGAlter
    {
        public override void DoNum()
        {
            Console.WriteLine("使用权宗地编号。");
        }
    }

    /// <summary>
    /// 所有权宗地变更
    /// </summary>
    public class SUQBGAlter : BGAlter
    {
        public override void DoNum()
        {
            Console.WriteLine("所有权宗地编号。");
        }
    }

    /// <summary>
    /// 变更工厂
    /// </summary>
    public abstract class BGFactory
    {
        public abstract BGAlter GetAlterObj();
    }

    /// <summary>
    /// 使用权变更车间
    /// </summary>
    public class SYQFactory : BGFactory
    {
        public override BGAlter GetAlterObj()
        {
            return new SYQBGAlter();
        }
    }

    /// <summary>
    /// 所有权变更车间
    /// </summary>
    public class SUQFactory : BGFactory
    {
        public override BGAlter GetAlterObj()
        {
            return new SUQBGAlter();
        }
    }

}
