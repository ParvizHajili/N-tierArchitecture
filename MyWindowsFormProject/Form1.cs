using Business.Abstract;
using Business.Concrete;
using Entities.Concrete.TableModels;

namespace MyWindowsFormProject
{
    public partial class Form1 : Form
    {
        private readonly ICarService _carService;
        public Form1()
        {
            _carService = new CarManager();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car()
            {
                Marka = textBox1.Text,
                Model = textBox2.Text,
                Color = textBox3.Text,
            };
            _carService.Add(car);

            MessageBox.Show("Car added");
        }
    }
}
