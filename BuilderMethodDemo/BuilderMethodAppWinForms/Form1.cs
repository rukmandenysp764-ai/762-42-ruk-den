using BuilderMethodClass;

namespace BuilderMethodAppWinForms
{
    public partial class Form1 : Form
    {
        private Director _director;
        private BouquetBuilder _currentBuilder;
        public Form1()
        {
            InitializeComponent();
            InitializeBuilderLogic();
        }

        private void InitializeBuilderLogic()
        {
            _director = new Director();
            // За замовчуванням — весільний букет
            radioWedding.Checked = true;
            SelectBuilder();
        }

        private void SelectBuilder()
        {
            if (radioRose.Checked)
                _currentBuilder = new RoseBouquetBuilder();
            else if (radioMixed.Checked)
                _currentBuilder = new MixedBouquetBuilder();
            else
                _currentBuilder = new WeddingBouquetBuilder();

            _director.SetBuilder(_currentBuilder);
            _currentBuilder.Reset();
            RefreshSteps();
        }

        private void RefreshSteps()
        {
            listSteps.Items.Clear();
            if (_currentBuilder?.Bouquet != null)
            {
                foreach (var part in _currentBuilder.Bouquet.GetParts())
                {
                    listSteps.Items.Add(part);
                }
            }
        }
        private void radioBouquet_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                SelectBuilder();
            }
        }


        private void radioWedding_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            SelectBuilder(); // скидає і створює новий
            var bouquet = _director.ConstructFull();
            RefreshSteps();
            MessageBox.Show("Букет повністю побудовано через Director!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SelectBuilder();
        }

        private void btnFlowers_Click(object sender, EventArgs e)
        {
            _director.StepAddFlowers();
            RefreshSteps();
        }

        private void btnWrapper_Click(object sender, EventArgs e)
        {
            _director.StepAddWrapper();
            RefreshSteps();
        }

        private void btnDecoration_Click(object sender, EventArgs e)
        {
            _director.StepAddDecoration();
            RefreshSteps();
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            _director.StepSetSize();
            RefreshSteps();
        }

        private void btnStyle_Click(object sender, EventArgs e)
        {
            _director.StepSetStyle();
            RefreshSteps();
        }

        private void btnRibbon_Click(object sender, EventArgs e)
        {
            _director.StepAddRibbon();
            RefreshSteps();
        }

        private void ButtonbtnClear_Click(object sender, EventArgs e)
        {
            listSteps.Items.Clear();
        }

        private void radioRose_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
