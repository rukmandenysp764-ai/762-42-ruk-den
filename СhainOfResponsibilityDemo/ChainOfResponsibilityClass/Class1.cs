using System.Collections.Generic;

public interface IAssemblyHandler
{
    IAssemblyHandler SetNext(IAssemblyHandler handler);
    void Handle(Smartphone phone);
}

public abstract class BaseAssemblyHandler : IAssemblyHandler
{
    protected IAssemblyHandler _next;

    public IAssemblyHandler SetNext(IAssemblyHandler handler)
    {
        _next = handler;
        return handler;
    }

    public virtual void Handle(Smartphone phone)
    {
        if (_next != null)
            _next.Handle(phone);
    }
}


public class Smartphone
{
    public string Model { get; set; }

    public bool FrameStatus { get; set; }
    public bool ScreenStatus { get; set; }
    public bool MotherboardStatus { get; set; }
    public bool BatteryStatus { get; set; }
    public bool CameraStatus { get; set; }
    public bool SoftwareStatus { get; set; }
    public bool FinalStatus { get; set; }

    public bool IsRejected { get; set; }

    public List<string> AssemblyLog { get; set; } = new List<string>();

    public bool IsReadyForShipment()
    {
        return FrameStatus && ScreenStatus && MotherboardStatus &&
               BatteryStatus && CameraStatus && SoftwareStatus &&
               FinalStatus && !IsRejected;
    }
}

public class FrameAssembler : BaseAssemblyHandler
{
    public override void Handle(Smartphone phone)
    {
        phone.FrameStatus = true;
        phone.AssemblyLog.Add("Frame assembled");

        base.Handle(phone);
    }
}

public class ScreenInstaller : BaseAssemblyHandler
{
    public override void Handle(Smartphone phone)
    {
        if (!phone.FrameStatus)
        {
            phone.IsRejected = true;
            phone.AssemblyLog.Add("Error: No frame");
            return;
        }

        phone.ScreenStatus = true;
        phone.AssemblyLog.Add("Screen installed");

        base.Handle(phone);
    }
}

public class MotherboardAssembler : BaseAssemblyHandler
{
    public override void Handle(Smartphone phone)
    {
        phone.MotherboardStatus = true;
        phone.AssemblyLog.Add("Motherboard installed");

        base.Handle(phone);
    }
}

public class BatteryInstaller : BaseAssemblyHandler
{
    public override void Handle(Smartphone phone)
    {
        phone.BatteryStatus = true;
        phone.AssemblyLog.Add("Battery installed");

        base.Handle(phone);
    }
}

public class CameraModuleInstaller : BaseAssemblyHandler
{
    public override void Handle(Smartphone phone)
    {
        phone.CameraStatus = true;
        phone.AssemblyLog.Add("Camera installed");

        base.Handle(phone);
    }
}

public class SoftwareFlasher : BaseAssemblyHandler
{
    public override void Handle(Smartphone phone)
    {
        phone.SoftwareStatus = true;
        phone.AssemblyLog.Add("Software flashed");

        base.Handle(phone);
    }
}

public class FinalQualityController : BaseAssemblyHandler
{
    public override void Handle(Smartphone phone)
    {
        if (phone.IsReadyForShipment())
        {
            phone.FinalStatus = true;
            phone.AssemblyLog.Add("Quality check passed");
        }
        else
        {
            phone.IsRejected = true;
            phone.AssemblyLog.Add("Quality check failed");
        }
    }
}

public class AssemblyLineClient
{
    public void StartAssembly(Smartphone phone)
    {
        var frame = new FrameAssembler();
        var screen = new ScreenInstaller();
        var motherboard = new MotherboardAssembler();
        var battery = new BatteryInstaller();
        var camera = new CameraModuleInstaller();
        var software = new SoftwareFlasher();
        var finalQC = new FinalQualityController();

        frame.SetNext(screen)
             .SetNext(motherboard)
             .SetNext(battery)
             .SetNext(camera)
             .SetNext(software)
             .SetNext(finalQC);

        frame.Handle(phone);
    }
}


