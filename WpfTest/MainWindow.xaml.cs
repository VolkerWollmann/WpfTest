using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfTest
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window, INotifyPropertyChanged
	{
		public ICommand MyCommand 
		{  
			get 
			{ 
				return new TestCommand(this);  
			} 
		}
		public MainWindow()
		{
			InitializeComponent();

			this.DataContext = this;

			//StackPanelWithCommand.IsEnabled = true;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void NotifyPropertyChanged(string info)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(info));
			}
		}

		private string _output;
		public string Output
		{
			set
			{
				_output = value;
				NotifyPropertyChanged("Output");
			}

			get
			{
				return _output;
			}
		}

		int counter = 0;
		private void BtnTest_Click(object sender, RoutedEventArgs e)
		{
			counter++;
			Output = counter.ToString() + " " + DateTime.Now.ToString();
			tboOutput1.Text = Output;
		}
	}
}
