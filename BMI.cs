

namespace WinFormsAppHello
{
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            
            string weightInput = txW.Text;
            double weight = double.Parse(weightInput);
            
            string heightInput = txH.Text;
            double heightcm = double.Parse(heightInput);

            double heightM = heightcm / 100.0;

            double bmi = weight / (heightM * heightM);

             


            if (bmi < 19)
                {
                lb3.Text = string.Format("BMI ของคุณคือ: {0:F2} ผอม", bmi);
            }
            else if (bmi >= 19)
            {
                lb3.Text = string.Format("BMI ของคุณคือ: {0:F2} น้ำหนักปกติ", bmi);
            }
            else if (bmi >= 23)
            {
                lb3.Text = string.Format("BMI ของคุณคือ: {0:F2} น้ำหนักมาก", bmi);
            }
            else if (bmi > 25)
            {
                lb3.Text = string.Format("BMI ของคุณคือ: {0:F2} อ้วน", bmi);
            }
            else
            {
               lb3.Text = string.Format("มีข้อผิดพลาด");



            }
        }
    }
}



