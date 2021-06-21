using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab3
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void button_Click(object sender, RoutedEventArgs e)
		{
			//Suma
			double a;
			double b;
			if (double.TryParse(text_a.Text, out a) && double.TryParse(text_b.Text, out b))
			{
				text_output.Text = String.Format("Suma {0} + {1} = {2}", a, b, a + b);
			}
			else
			{
				MessageBox.Show("Podaj poprawnie liczby");
			}
		}

		private void button_Copy_Click(object sender, RoutedEventArgs e)
		{
			//Różnica
			double a;
			double b;
			if (double.TryParse(text_a.Text, out a) && double.TryParse(text_b.Text, out b))
			{
				text_output.Text = String.Format("Różnica {0} - {1} = {2}", a, b, a - b);
			}
			else
			{
				MessageBox.Show("Podaj poprawnie liczby");
			}
		}

		private void button_Copy1_Click(object sender, RoutedEventArgs e)
		{
			//Iloczyn
			double a;
			double b;
			if (double.TryParse(text_a.Text, out a) && double.TryParse(text_b.Text, out b))
			{
				text_output.Text = String.Format("Iloczyn {0} * {1} = {2}", a, b, a * b);
			}
			else
			{
				MessageBox.Show("Podaj poprawnie liczby");
			}
		}

		private void button_Copy2_Click(object sender, RoutedEventArgs e)
		{
			//Iloraz
			double a;
			double b;
			if (double.TryParse(text_a.Text, out a) && double.TryParse(text_b.Text, out b))
			{
				if (b == 0)
				{
					MessageBox.Show("b musi być większe od 0");
				} 
				else
				{
					text_output.Text = String.Format("Iloraz {0} / {1} = {2}", a, b, a / b);
				}
			}
			else
			{
				MessageBox.Show("Podaj poprawnie liczby");
			}
		}
	}
}
