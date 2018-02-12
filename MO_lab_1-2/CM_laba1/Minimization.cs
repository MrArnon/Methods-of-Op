using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_laba1
{
	class Minimization
	{
		private double a, b, eps;
		public double x { get; set; }
		public double fx { get; set; }
		private double Function(double x)
		{
			return x * x + 2 * x;
		}
		public Minimization(double A, double B, double EPS)
		{
			a = A;
			b = B;
			eps = EPS;
		}
		public void Asunder()
		{
			double beta = eps * 0.01;
			double u=b-a, v=(b-a)/2 +beta ;
			while (Math.Abs(b-a) > eps)
			{
				u = (a + b) / 2 - beta;
				v = (a + b) / 2 + beta;

				if (Function(v) > Function(u)) { b = u;  }
				else { a = v;  }
				
	}
			x = (a + b) / 2;
			fx = Function(x);
		}
		public void Golden() {
			double phi = (Math.Sqrt(5) - 1) / 2;
			double x1 = a + phi * (b - a);
			double x2 = b - phi * (b - a);
			while ((b - a) > eps)
			{
				x1 = a + phi * (b - a);
				x2 = b - phi * (b - a);
				if (Function(x1) > Function(x2))

					b = x1;
				else
					a = x2;
			}
			x = x2;
			fx = Function(x2);
		}

		

	}

}

