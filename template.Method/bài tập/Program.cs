using luyện_template.Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luyện_template.Method
{
    public abstract class TextProcessor
    {
        public void Process() {
            PlainTextProcessor();
            HtmlProcessor();
            MarkdownProcessor();
        }
        protected abstract void MarkdownProcessor();
        protected abstract void PlainTextProcessor();
        protected abstract void HtmlProcessor();
     
    }
    public class Text_1 : TextProcessor
    {
        protected override void HtmlProcessor()
        {
            Console.WriteLine("xử lý Html của loại tệp thứ nhất");
        }
        protected override void MarkdownProcessor()
        {
            Console.WriteLine("xử lý markdown của loại tệp thứ nhất");
        }
        protected override void PlainTextProcessor()
        {
            Console.WriteLine("xử lý PlainText của loại tệp thứ nhất");
        }
    }
    public class  Text_2 : TextProcessor
    {
        protected override void HtmlProcessor()
        {
            Console.WriteLine("xử lý Html của loại tệp thứ hai");
        }
        protected override void MarkdownProcessor()
        {
            Console.WriteLine("xử lý markdown của loại tệp thứ hai ");
        }
        protected override void PlainTextProcessor()
        {
            Console.WriteLine("xử lý PlainText  của loại tệp thứ hai");
        }
    }

}
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.ForegroundColor=ConsoleColor.Red;
        TextProcessor tep1 = new Text_1();
        tep1.Process();
        Console.ResetColor();
        Console.WriteLine();
        Console.ForegroundColor=ConsoleColor.Green;
        TextProcessor tep2 = new Text_2();
        tep1.Process();
        Console.ResetColor();
        Console.ReadLine();

    }
    }
