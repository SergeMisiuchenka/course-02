using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XMLOpen");
        }
        public override void Create()
        {
            Console.WriteLine("XMLCreate");
        }
        public override void Change()
        {
            Console.WriteLine("XMLChange");
        }
        public override void Save()
        {
            Console.WriteLine("XMLSave");
        }

    }
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXTOpen");
        }
        public override void Create()
        {
            Console.WriteLine("TXTCreate");
        }
        public override void Change()
        {
            Console.WriteLine("TXTChange");
        }
        public override void Save()
        {
            Console.WriteLine("TXTSave");
        }
    }
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOCOpen");
        }
        public override void Create()
        {
            Console.WriteLine("DOCCreate");
        }
        public override void Change()
        {
            Console.WriteLine("DOCChange");
        }
        public override void Save()
        {
            Console.WriteLine("DOCSave");
        }
    }
}
