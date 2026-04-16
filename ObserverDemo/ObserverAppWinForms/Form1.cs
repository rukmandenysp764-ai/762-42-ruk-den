using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using ObserverClass;

namespace ObserverAppWinForms
{
    public partial class Form1 : Form
    {
        private DayTimeCycle cycle = new DayTimeCycle();
        private List<SceneElement> elements = new List<SceneElement>();

        public Form1()
        {
            InitializeComponent();

            this.Paint += Form1_Paint;
            // створюємо об'єкти
            var house = new House();
            var tree = new Tree();
            var flower = new Flower();

            elements.Add(house);
            elements.Add(tree);
            elements.Add(flower);

            // підписка
            foreach (var el in elements)
            {
                cycle.Attach(el);
            }

            SetTime(TimeOfDay.Day);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // фон залежно від часу
            e.Graphics.Clear(currentBackground);

            foreach (var el in elements)
            {
                el.Draw(e.Graphics);
            }
        }

        private Color currentBackground = Color.LightBlue;

        private void SetTime(TimeOfDay time)
        {
            switch (time)
            {
                case TimeOfDay.Morning:
                    currentBackground = Color.LightSkyBlue;
                    break;
                case TimeOfDay.Day:
                    currentBackground = Color.DeepSkyBlue;
                    break;
                case TimeOfDay.Evening:
                    currentBackground = Color.OrangeRed;
                    break;
                case TimeOfDay.Night:
                    currentBackground = Color.DarkBlue;
                    break;
            }

            cycle.SetTimeOfDay(time);
            Invalidate(); // перерисовка
        }

        private void btnMorning_Click(object sender, EventArgs e)
        {
            SetTime(TimeOfDay.Morning);
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            SetTime(TimeOfDay.Day);
        }

        private void btnEvening_Click(object sender, EventArgs e)
        {
            SetTime(TimeOfDay.Evening);

        }

        private void btnNight_Click(object sender, EventArgs e)
        {
            SetTime(TimeOfDay.Night);

        }
    }
}
