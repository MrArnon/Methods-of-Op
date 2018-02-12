using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CM_laba1
{
    public partial class Form_for_graphic : Form
    {
        public Form_for_graphic()
        {
            InitializeComponent();
        }

        private void Start_but_Click(object sender, EventArgs e)
        {
            Graphic.Series[0].Points.Clear();
            Function_graphics graf = new Function_graphics();
			
			try
            {
                graf.a = Convert.ToDouble(A_box.Text);
                graf.b = Convert.ToDouble(B_box.Text);
				
				if (graf.a >= graf.b)
                {
                    MessageBox.Show("Неверный ввод");
                    A_box.Text = string.Empty;
                    B_box.Text = string.Empty;
                    Epsilon_text.Text = Convert.ToString( 0.001);
                    graf.flag = false;
                }
            }
            catch (Exception) { MessageBox.Show("Неверный ввод");
                A_box.Text = string.Empty;
                B_box.Text = string.Empty;
                Epsilon_text.Text = Convert.ToString(0.001);
                graf.flag = false; }

			if (graf.flag)
            {
				try
				{
					Minimization minimization = new Minimization(graf.a, graf.b, Convert.ToDouble(Epsilon_text.Text));
					graf.H();
					for (double i = graf.a; i <= graf.b; i += graf.h)
					{

						Graphic.Series[0].Points.AddXY(i, graf.Func(i));

					}
					minimization.Golden();
					Func_value_text.Text = Convert.ToString(minimization.fx);
					Value_text.Text = Convert.ToString(minimization.x);
				}
				catch (System.FormatException) { MessageBox.Show("Неверный ввод"); Epsilon_text.Text = Convert.ToString(0.001); }
				}
        }

		private void Asunder_but_Click(object sender, EventArgs e)
		{
			Graphic.Series[0].Points.Clear();
			Function_graphics graf = new Function_graphics();

			try
			{
				graf.a = Convert.ToDouble(A_box.Text);
				graf.b = Convert.ToDouble(B_box.Text);

				if (graf.a >= graf.b)
				{
					MessageBox.Show("Неверный ввод");
					A_box.Text = string.Empty;
					B_box.Text = string.Empty;
					Epsilon_text.Text = Convert.ToString(0.001);
					graf.flag = false;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Неверный ввод");
				A_box.Text = string.Empty;
				B_box.Text = string.Empty;
				Epsilon_text.Text = Convert.ToString(0.001);
				graf.flag = false;
			}

			if (graf.flag)
			{
				try
				{
					Minimization minimization = new Minimization(graf.a, graf.b, Convert.ToDouble(Epsilon_text.Text));
					graf.H();
					for (double i = graf.a; i <= graf.b; i += graf.h)
					{

						Graphic.Series[0].Points.AddXY(i, graf.Func(i));

					}
					minimization.Asunder();
					Func_value_text.Text = Convert.ToString(minimization.fx);
					Value_text.Text = Convert.ToString(minimization.x);
				}
				catch (System.FormatException) { MessageBox.Show("Неверный ввод"); Epsilon_text.Text = Convert.ToString(0.001); }
			}
		}
	}
	}


