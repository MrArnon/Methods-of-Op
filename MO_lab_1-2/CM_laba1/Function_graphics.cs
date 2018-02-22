using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CM_laba1
{
    class Function_graphics
    {
        public double a { get; set; }
        public double b { get; set; }
        public double h { get; set; }
        public int n { get; set; }
        public int m { get; set; }
        public bool flag { get; set; }
		public struct Mas
		{
			public double XI { get; set; }
			public double FX { get; set; }

			public Mas(double xi, double fx)
			{
				XI = xi;
				FX = fx;

			}
		}
		public struct Table
		{
			public double Tabx { get; set; }
			public double Tabn { get; set; }
			public Table(double tabx, double tabn)
			{
				Tabx = tabx;
				Tabn = tabn;


			}
		}
		public List<Mas> mas = new List<Mas>();
		public double[,] tabel;
		public double kol  { get; set; }
		public Function_graphics()
        {
            flag = true;
            a = -1.0;
            b = 1.0;
            m = 10;
            h = 0.001;
            n = -1;
			kol = 0;
		}
        public double Func(double x)
        {
			/* double f;
			 f = x * x + 2 * x;
			 return f;
	 */
			return (Math.Exp(x)+ Math.Exp(-x))/2;
		}
        public void H()
        {
            h= 0.01; 
        }
        public double Polin(double x)
        {
            double sum = 0.0, pr1, pr2;
            for (double i = a; i <= b; i += h)
            {
                pr1 = 1.0;
                pr2 = 1.0;
                for (double j = a; j <= b; j += h)
                {
                    if (i != j)
                    {

                        pr1 *= (x - j);
                        pr2 *= (i - j);
                    }
                }
                sum = sum + Func(i) * (double)(pr1 / pr2);
            }
            return sum;
        }

		
		//построение многочлена
		public double polynomial(double g)
		{
			
			mas.Clear();
			double c = b - a;
			kol = c / n;
			double a0 = a + kol;
			double b0 = b;
			Mas temp = new Mas(a, Func(a));
			mas.Add(temp);


			for (double i = a0; i < b0 + kol; i += kol)
			{
				Mas temp0 = new Mas(i, Func(i));
				mas.Add(temp0);
				
			}
			double rez = 0;
			for (int i = 0; i < n + 1; i++)
			{
				rez += denominator(i) * numerator(i, g);

			}

			return rez;	
				
			
			

		}
		//нахождение знаменателя

		private double denominator(int j)
		{
			double rez = 1;
			double rez2 = 0;
			double rez1 = 0;
			if (j == 0) return mas[j].FX;

			for (int h = 0; h < j + 1; h++)
			{

				for (int k = 0; k < j + 1; k++)

				{

					if (k != h)

						rez *= (mas[h].XI - mas[k].XI);

				}
				rez1 = mas[h].FX;
				rez2 += rez1 / rez;
				rez = 1;
			}
			return rez2;

		}
		
		//числитель
		private double numerator(int j, double x)
		{

			double rez = 1;
			for (int l = 0; l < j; l++)
			{

				if (l != j)

					rez *= (x - mas[l].XI);
			}

			return rez;
		}
		//построение многочлена по таблице
		public double graf_table(double g)
		{
			mas.Clear();
			double c = b - a;
			kol = c / n;
			double a0 = a + kol;
			double b0 = b;
			Mas temp = new Mas(a, Func(a));
			mas.Add(temp);

			



			for (double i = a0; i < b0 + kol; i += kol)
			{
				Mas temp0 = new Mas(i, Func(i));
				mas.Add(temp0);
				
			}
			tbl_mas(mas.Count());


			for (int y = 1; y < n + 1; y++)
			{
				create_table(y);
			}


			
				double rez = 0;
			for (int i = 0; i < n + 1; i++)
			{
				rez += denominator_table(i) * numerator(i, g);


			}

			return rez;
		}

		private void tbl_mas(int h)
		{

			for (int j = 0; j <h ; j++)
			{
				tabel[j, 0] = mas[j].XI;

			}

			for (int j = 0; j < h; j++)
			{
				tabel[j, 1] = mas[j].FX;

			}

		}



		//таблица
		private void create_table(int j)
		{
			int ha = 2;
			int ko = 1;
			int no = j + 1;
			for (int h = ha; h < j + 1; h++)
			{
				for (int k = 0; k < no; k++)
				{
					tabel[k, h] = (tabel[k, h - 1] - tabel[k + 1, h - 1]) / (tabel[k, 0] - tabel[k + ko, 0]);

				}
				ko++;
				no--;
			}
		}

		private double denominator_table(int j)
		{

			return tabel[0, j + 1];

		}
	}
}
