using System.Collections.Generic;

public class Product
{
    public bool VisualStatus { get; set; }
    public bool TechnicalStatus { get; set; }
    public bool FinalStatus { get; set; }

    public bool IsRejected { get; set; }

    public List<string> InspectionLog { get; set; } = new List<string>();

    public bool IsRejectedMethod()
    {
        return IsRejected || !FinalStatus;
    }
}
public interface IQualityHandler
{
    IQualityHandler SetNext(IQualityHandler handler);
    void Handle(Product product);
}

public abstract class BaseQualityHandler : IQualityHandler
{
    protected IQualityHandler _next;

    public IQualityHandler SetNext(IQualityHandler handler)
    {
        _next = handler;
        return handler;
    }

    public virtual void Handle(Product product)
    {
        _next?.Handle(product);
    }
}

public class VisualInspector : BaseQualityHandler
{
    public override void Handle(Product product)
    {
        product.VisualStatus = true;
        product.InspectionLog.Add("Visual inspection passed");

        base.Handle(product);
    }
}

public class TechnicalChecker : BaseQualityHandler
{
    public override void Handle(Product product)
    {
        if (!product.VisualStatus)
        {
            product.IsRejected = true;
            product.InspectionLog.Add("Technical check failed (visual not passed)");
            return;
        }

        product.TechnicalStatus = true;
        product.InspectionLog.Add("Technical check passed");

        base.Handle(product);
    }
}

public class FinalController : BaseQualityHandler
{
    public override void Handle(Product product)
    {
        if (product.VisualStatus && product.TechnicalStatus)
        {
            product.FinalStatus = true;
            product.InspectionLog.Add("Final control passed");
        }
        else
        {
            product.IsRejected = true;
            product.InspectionLog.Add("Final control failed");
        }
    }
}

public class QualityControlClient
{
    public void RunInspection(Product product)
    {
        var visual = new VisualInspector();
        var technical = new TechnicalChecker();
        var final = new FinalController();

        visual.SetNext(technical)
              .SetNext(final);

        visual.Handle(product);
    }
}