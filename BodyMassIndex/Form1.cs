namespace BodyMassIndex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double size = Convert.ToDouble(textBox1.Text);
            double weight = Convert.ToDouble(textBox2.Text);
            string gender = "";
            if (radioButton1.Checked)
                gender = "Male";
            else if (radioButton2.Checked)
                gender = "Female";
            PersonBodyMass personBodyMass = new PersonBodyMass(size, weight, gender);
            double bmi = personBodyMass.calculateBmi();
            // Display the BMI result in the list box
            listBox1.Items.Add("Your BMI is: " + Math.Round(bmi, 2));
            listBox1.Items.Add("Your age is: " + textBox3.Text);
            listBox1.Items.Add("Your gender is: " + personBodyMass.GetGender());

            // Determine the BMI category based on the calculated BMI
            if (bmi < 18.4)
            {
                listBox1.Items.Add("You are too weak.");
            }
            else if (bmi > 18.5 && bmi <= 24.99)
            {
                listBox1.Items.Add("You are healthy.");
            }
            else if (bmi > 24.99 && bmi <= 29.99)
            {
                listBox1.Items.Add("You are overweight.");
            }
            else if (bmi > 29.99 && bmi <= 39.99)
            {
                listBox1.Items.Add("You are obese.");
            }
            else if (bmi >= 40)
            {
                listBox1.Items.Add("You are morbidly obese.");
            }
        }
    }
}
