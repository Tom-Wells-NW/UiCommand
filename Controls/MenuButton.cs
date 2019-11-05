using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace UiCommand.Controls
{
	public class MenuButton : Button
	{
		public MenuButton()
		{
			Click += OnClick;
		}
		
		void OnClick(object sender, RoutedEventArgs e)
		{

			if (this.ContextMenu == null)
				return;

			this.ContextMenu.IsEnabled = true;
			this.ContextMenu.PlacementTarget = (sender as Button);
			this.ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
			this.ContextMenu.IsOpen = true;
		}
	}
}
