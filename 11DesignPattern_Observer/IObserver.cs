using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11DesignPattern_Observer
{
    /// <summary>
    /// 订阅者接口
    /// </summary>
    public interface IObserver
    {

        void Receive(Blog blog);
    }
}
