using WinFormsApp2;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private List<Appliance> appliances = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Appliance_button_Click(object sender, EventArgs e)
        {
            try
            {
                string brand = brand_textBox.Text == "марка" ? string.Empty : brand_textBox.Text;
                string model = model_textBox.Text == "модель" ? string.Empty : model_textBox.Text;
                string color = color_textBox.Text == "цвет" ? string.Empty : color_textBox.Text;

                appliances.Add(new Appliance(brand, model, color));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            color_textBox.Text = "цвет";
            model_textBox.Text = "модель";
            brand_textBox.Text = "марка";
        }

        private void WashingMaching_button_Click(object sender, EventArgs e)
        {
            try
            {
                string brand = brand_textBox.Text == "марка" ? string.Empty : brand_textBox.Text;
                string model = model_textBox.Text == "модель" ? string.Empty : model_textBox.Text;
                string color = color_textBox.Text == "цвет" ? string.Empty : color_textBox.Text;
                int capacity = int.Parse(choice_textBox.Text);
                appliances.Add(new WashingMachine(brand, model, color, capacity));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            color_textBox.Text = "цвет";
            model_textBox.Text = "модель";
            brand_textBox.Text = "марка";
            choice_textBox.Text = "емкость";

        }

        private void Dishwasher_button_Click(object sender, EventArgs e)
        {
            try
            {
                string brand = brand_textBox.Text == "марка" ? string.Empty : brand_textBox.Text;
                string model = model_textBox.Text == "модель" ? string.Empty : model_textBox.Text;
                string color = color_textBox.Text == "цвет" ? string.Empty : color_textBox.Text;
                int numberOfPrograms = int.Parse(choice_textBox.Text);

                appliances.Add(new Dishwasher(brand, model, color, numberOfPrograms));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            color_textBox.Text = "цвет";
            model_textBox.Text = "модель";
            brand_textBox.Text = "марка";
            choice_textBox.Text = "количесво программ";
        }

        private void model_textBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(model_textBox.Text) || model_textBox.Text == "модель")
            {
                model_textBox.Text = "модель";
                model_textBox.ForeColor = Color.Gray;
            }
        }
        private void brand_textBox_Enter(object sender, EventArgs e)
        {
            if (brand_textBox.Text == "марка")
            {
                brand_textBox.Clear();
                brand_textBox.ForeColor = Color.Black;
            }
        }

        private void brand_textBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(brand_textBox.Text) || brand_textBox.Text == "марка")
            {
                brand_textBox.Text = "марка";
                brand_textBox.ForeColor = Color.Gray;
            }
        }

        private void color_textBox_Enter(object sender, EventArgs e)
        {
            if (color_textBox.Text == "цвет")
            {
                color_textBox.Clear();
                color_textBox.ForeColor = Color.Black;
            }
        }

        private void color_textBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(color_textBox.Text) || color_textBox.Text == "цвет")
            {
                color_textBox.Text = "цвет";
                color_textBox.ForeColor = Color.Gray;
            }
        }



        private void printButton_Click(object sender, EventArgs e)
        {
            printButton.Text = string.Empty;
            foreach (var item in appliances)
                textBox4.Text += item.ToString() + "\r\n";
        }


        private void choice_textBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(choice_textBox.Text) || choice_textBox.Text == "емкость/количество программ")
            {
                choice_textBox.Text = "емкость/количество программ";
                choice_textBox.ForeColor = Color.Gray;
            }
        }



        private void model_textBox_Enter_1(object sender, EventArgs e)
        {
            if (model_textBox.Text == "модель")
            {
                model_textBox.Clear();
                model_textBox.ForeColor = Color.Black;
            }
        }


        private void choice_textBox_Enter(object sender, EventArgs e)
        {
            if (choice_textBox.Text == "емкость/количество программ")
            {
                choice_textBox.Clear();
                choice_textBox.ForeColor = Color.Black;
            }
        }
    }
}