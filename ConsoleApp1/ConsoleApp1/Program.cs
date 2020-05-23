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
            var post = new Table_1()
            {
                Body = "body",
                DatePublished = DateTime.Now,
                Title = "title",
                PostId = 1
            };
            context.Table_1.Add(post);
            context.SaveChanges();

            Console.WriteLine("done");

            
        }
    }
}
