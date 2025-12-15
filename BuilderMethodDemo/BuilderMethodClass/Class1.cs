namespace BuilderMethodClass
{

    public abstract class Bouquet
    {
        protected List<string> _parts = new List<string>();

        public void AddPart(string part)
        {
            _parts.Add(part);
        }

        public override string ToString()
        {
            if (_parts.Count == 0)
                return "Букет порожній.";

            return "Склад букета:\n" + string.Join("\n", _parts);
        }

        public List<string> GetParts() => _parts;
    }

    public class RoseBouquet : Bouquet { }

    public class MixedBouquet : Bouquet { }

    public class WeddingBouquet : Bouquet { }
}

namespace BuilderMethodClass
{
    public abstract class BouquetBuilder
    {
        protected Bouquet _bouquet;

        public Bouquet Bouquet => _bouquet;

        public abstract void Reset();

        public abstract void AddFlowers();
        public abstract void AddWrapper();
        public abstract void AddDecoration();
        public abstract void SetSize();
        public abstract void SetStyle();

        public virtual void AddRibbon()
        {
            _bouquet.AddPart("➕ Додано декоративну стрічку");
        }

        public Bouquet GetResult()
        {
            return _bouquet;
        }
    }
}

namespace BuilderMethodClass
{
    public class RoseBouquetBuilder : BouquetBuilder
    {
        public override void Reset()
        {
            _bouquet = new RoseBouquet();
        }

        public override void AddFlowers()
        {
            _bouquet.AddPart("Додано 15 червоних роз");
        }

        public override void AddWrapper()
        {
            _bouquet.AddPart("Обгорнуто папером");
        }

        public override void AddDecoration()
        {
            _bouquet.AddPart("Додано декорації");
        }

        public override void SetSize()
        {
            _bouquet.AddPart("Встановлено розмір: великий");
        }

        public override void SetStyle()
        {
            _bouquet.AddPart("Стиль: класичний");
        }

        public override void AddRibbon()
        {
            _bouquet.AddPart("Додано стрічку");
        }
    }
}

namespace BuilderMethodClass
{
    public class MixedBouquetBuilder : BouquetBuilder
    {
        public override void Reset()
        {
            _bouquet = new MixedBouquet();
        }

        public override void AddFlowers()
        {
            _bouquet.AddPart("Додано мікс: троянди, лілії, хризантеми");
        }

        public override void AddWrapper()
        {
            _bouquet.AddPart("Обгорнуто в плівку");
        }

        public override void AddDecoration()
        {
            _bouquet.AddPart("Додано декорації");
        }

        public override void SetSize()
        {
            _bouquet.AddPart("Встановлено розмір: середній");
        }

        public override void SetStyle()
        {
            _bouquet.AddPart("Стиль: польовий");
        }

        public override void AddRibbon()
        {
            _bouquet.AddPart("Додано стрічку");
        }
    }
}

namespace BuilderMethodClass
{
    public class WeddingBouquetBuilder : BouquetBuilder
    {
        public override void Reset()
        {
            _bouquet = new WeddingBouquet();
        }

        public override void AddFlowers()
        {
            _bouquet.AddPart("Додано білі троянди, піони та орхідеї");
        }

        public override void AddWrapper()
        {
            _bouquet.AddPart("Обгорнуто тканиною");
        }

        public override void AddDecoration()
        {
            _bouquet.AddPart("Додано декорації");
        }

        public override void SetSize()
        {
            _bouquet.AddPart("Встановлено розмір: великий");
        }

        public override void SetStyle()
        {
            _bouquet.AddPart("Стиль: весільний");
        }

        public override void AddRibbon()
        {
            _bouquet.AddPart("Додано стрічку");
        }
    }
}

namespace BuilderMethodClass
{

    public class Director
    {
        private BouquetBuilder _builder;

        public void SetBuilder(BouquetBuilder builder)
        {
            _builder = builder;
        }

        public Bouquet ConstructFull()
        {
            _builder.Reset();
            _builder.AddFlowers();
            _builder.AddWrapper();
            _builder.AddDecoration();
            _builder.SetSize();
            _builder.SetStyle();
            _builder.AddRibbon();

            return _builder.GetResult();
        }

        public void StepAddFlowers() => _builder.AddFlowers();
        public void StepAddWrapper() => _builder.AddWrapper();
        public void StepAddDecoration() => _builder.AddDecoration();
        public void StepSetSize() => _builder.SetSize();
        public void StepSetStyle() => _builder.SetStyle();
        public void StepAddRibbon() => _builder.AddRibbon();
    }
}

