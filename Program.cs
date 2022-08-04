using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ACCESS_MODIFIERS
{
    class program
    { 
        internal void BAPATLA()
        {
        Console.WriteLine("HELLO BAPATLA.......");
        }
        public void SRAVAN()
        {
            Console.WriteLine("HELLO SRAVAN......");
        }
        private void RAVAN()
        { 
            Console.WriteLine("HELLO RAVAN.......");
        }
        protected void hello()
        {
            Console.WriteLine("hello.............");
        }
        protected internal void world()
        {
            Console.WriteLine("world...........");
        }
        static void Main(string[] args)
        {
            program obj = new program();
            obj.hello();
            obj.world();
            obj.SRAVAN();
            obj.RAVAN();
            obj.BAPATLA();
        }
    }
}
