using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfTest
{

	/// <summary>
	/// Binding command
	/// https://www.youtube.com/watch?v=fOookEq5od0
	/// </summary>
	class TestCommand : ICommand
	{
		MainWindow Mw;
		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			Mw.StackPanelWithCommand.Focus();
		}

		public TestCommand(MainWindow mw)
		{
			Mw = mw;
		}
	}
}
