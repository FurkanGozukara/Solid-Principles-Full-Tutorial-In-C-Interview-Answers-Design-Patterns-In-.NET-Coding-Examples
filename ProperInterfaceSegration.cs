using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace solid_design_principles
{
    internal class ProperInterfaceSegration
    {
        public abstract class ab1
        {

        }

        public abstract class ab2
        {

        }

        public interface IPrinterTasks
        {
            void Print(string PrintContent);
            void Scan(string ScanContent);
        }
        interface IFaxTasks
        {
            void Fax(string content);
        }
        interface IPrintDuplexTasks
        {
            void PrintDuplex(string content);
        }

        public class HPLaserJetPrinter : IPrinterTasks, IFaxTasks,
                                     IPrintDuplexTasks
        {
            public void Print(string PrintContent)
            {
                Console.WriteLine("Print Done");
            }
            public void Scan(string ScanContent)
            {
                Console.WriteLine("Scan content");
            }
            public void Fax(string FaxContent)
            {
                Console.WriteLine("Fax content");
            }
            public void PrintDuplex(string PrintDuplexContent)
            {
                Console.WriteLine("Print Duplex content");
            }
        }

        class LiquidInkjetPrinter : IPrinterTasks
        {
            public void Print(string PrintContent)
            {
                Console.WriteLine("Print Done");
            }
            public void Scan(string ScanContent)
            {
                Console.WriteLine("Scan content");
            }
        }
    }
}
