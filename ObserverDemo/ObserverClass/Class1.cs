using System.Collections.Generic;
using System.Drawing;


public enum TimeOfDay
{
    Morning,
    Day,
    Evening,
    Night
}


public interface IObserver
{
    void Update(TimeOfDay time);
}

public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}

namespace ObserverClass
{
    public class House : SceneElement
    {
        private Color roofColor = Color.Red;
        private bool windowLight = false;

        public override void Update(TimeOfDay time)
        {
            switch (time)
            {
                case TimeOfDay.Morning:
                case TimeOfDay.Day:
                    windowLight = false;
                    break;
                case TimeOfDay.Evening:
                case TimeOfDay.Night:
                    windowLight = true;
                    break;
            }
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Beige, 100, 150, 100, 100);

            Brush roofBrush = new SolidBrush(roofColor);
            g.FillPolygon(roofBrush, new Point[]
            {
            new Point(100,150),
            new Point(150,100),
            new Point(200,150)
            });

            // Вікно
            Brush windowBrush = windowLight ? Brushes.Yellow : Brushes.DarkBlue;
            g.FillRectangle(windowBrush, 130, 180, 20, 20);
        }
    }

    public class Tree : SceneElement
    {
        private Color leafColor = Color.Green;

        public override void Update(TimeOfDay time)
        {
            switch (time)
            {
                case TimeOfDay.Morning:
                    leafColor = Color.LightGreen;
                    break;
                case TimeOfDay.Day:
                    leafColor = Color.Green;
                    break;
                case TimeOfDay.Evening:
                    leafColor = Color.Orange;
                    break;
                case TimeOfDay.Night:
                    leafColor = Color.DarkGreen;
                    break;
            }
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Brown, 300, 180, 20, 70);

            Brush leafBrush = new SolidBrush(leafColor);
            g.FillEllipse(leafBrush, 270, 130, 80, 80);
        }
    }

    public class Flower : SceneElement
    {
        private bool isBlooming = true;

        public override void Update(TimeOfDay time)
        {
            isBlooming = time != TimeOfDay.Night;
        }

        public override void Draw(Graphics g)
        {
            if (isBlooming)
            {
                g.FillEllipse(Brushes.Pink, 400, 200, 20, 20);
            }
            else
            {
                g.FillEllipse(Brushes.Gray, 400, 200, 10, 10);
            }
        }
    }


    public class DayTimeCycle : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private TimeOfDay currentTime;

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(currentTime);
            }
        }

        public void SetTimeOfDay(TimeOfDay newTime)
        {
            currentTime = newTime;
            Notify();
        }
    }


    public abstract class SceneElement : IObserver
    {
        public string Name { get; set; }

        public abstract void Update(TimeOfDay time);

        public abstract void Draw(Graphics g);
    }

}