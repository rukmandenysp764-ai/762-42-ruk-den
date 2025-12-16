using DecoratorMethodClass;

namespace DecoratorMethodAppWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            GreetingCard card = new SimpleGreetingCard();

            if (chkRibbon.Checked)
                card = new RibbonDecorator(card);

            if (chkFlowers.Checked)
                card = new FlowersDecorator(card);

            if (chkFrame.Checked)
                card = new FrameDecorator(card);

            rtbResult.Clear();
            rtbResult.AppendText("Опис листівки:\n");
            rtbResult.AppendText(card.GetDescription() + "\n\n");
            rtbResult.AppendText($"Вартість: {card.GetCost():C}");
        }
    }
}
