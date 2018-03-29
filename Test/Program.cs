using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            test1();
            //test2();
        }

        private static void test2()
        {
            string str1 = formatPara(new { Id = 1, Name = "test2" });
            Test1 t1 = new Test1() { Id = 1, Name = "test2" };
            string str2 = formatPara(t1);
        }
        class Test1
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        static string formatPara(object para)
        {
            if (para == null)
                return string.Empty;
            else
            {
                var dic = new System.Web.Routing.RouteValueDictionary(para);
                return $"?{string.Join("&", dic.Select(p => p.Key + "=" + p.Value))}";
            }
        }

        static void test1()
        {
            string str = Guid.NewGuid().ToString();
            Console.WriteLine(str);
        }
    }
}
