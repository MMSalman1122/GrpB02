using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var context=new DataBaseDemoEntities();
            var post = new Test()
            {
                Body = "body",
                DatePublished = DateTime.Now,
                Title = "title",
                PostId = 1
            };
            context.Tests.Add(post);
            context.SaveChanges();

            Console.WriteLine("done");

            
        }
    }
}
