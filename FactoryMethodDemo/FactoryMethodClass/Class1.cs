using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodClass
{
    public abstract class Facade
    {
        public abstract void Display();
    }
}

namespace FactoryMethodClass
{
    public class ClassicFacade : Facade
    {
        public override void Display()
        {
            Console.WriteLine("Classic Facade");
        }
    }
}

namespace FactoryMethodClass
{
    public class BaroqueFacade : Facade
    {
        public override void Display()
        {
            Console.WriteLine("Baroque Facade");
        }
    }
}

namespace FactoryMethodClass
{
    public class ModernFacade : Facade
    {
        public override void Display()
        {
            Console.WriteLine("Modern Facade");
        }
    }
}

namespace FactoryMethodClass
{
    public abstract class Master
    {
        public abstract Facade CreateFacade();
    }
}

namespace FactoryMethodClass
{
    public class ClassicMaster : Master
    {
        public override Facade CreateFacade()
        {
            return new ClassicFacade();
        }
    }
}

namespace FactoryMethodClass
{
    public class BaroqueMaster : Master
    {
        public override Facade CreateFacade()
        {
            return new BaroqueFacade();
        }
    }
}

namespace FactoryMethodClass
{
    public class ModernMaster : Master
    {
        public override Facade CreateFacade()
        {
            return new ModernFacade();
        }
    }
}