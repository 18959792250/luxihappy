using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11DesignPattern_ObserverDelegateTest
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--全部订阅者--");
            //创建一个JiYF的博客
            Blog jiyfBlog = new Blog("JiYF笨小孩","丑小鸭","丑小鸭的故事");
            
            //创建订阅者
            Observer obsZhangsan    = new Observer("张三");
            Observer obsLiSi        = new Observer("李四");
            Observer obsWangwu      = new Observer("王五"); 

            //添加对JiYF博客的订阅者
            jiyfBlog.AddObserver(new NotifyEventHandler(obsZhangsan.Receive));
            jiyfBlog.AddObserver(new NotifyEventHandler(obsLiSi.Receive));
            jiyfBlog.AddObserver(new NotifyEventHandler(obsWangwu.Receive));

            ////通知订阅者
            jiyfBlog.PublishBlog();

            Console.WriteLine("---移除订阅者张三--");
            jiyfBlog.RemoteObserver(new NotifyEventHandler(obsZhangsan.Receive));
            jiyfBlog.PublishBlog();
            Console.ReadLine();
        }
    }
}
