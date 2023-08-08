using Godot;
using System;

public class ButtonMode : CheckButton
{
	//store panel
	Panel panel;
	
	//store themes
	Theme lightTheme = (Theme)GD.Load("res://theme/sci-fi-theme-light.tres");
	Theme darkTheme = (Theme)GD.Load("res://theme/sci-fi-theme-dark.tres");

	public override void _Ready()
	{	
		//get panel based on directory path	
		panel = GetNode<Godot.Panel>("/root/Main/Panel");
	}

	private void OnToggled(bool button_pressed)
	{
		if (button_pressed)
		{
			//toggle panel to dark mode
			panel.Theme = darkTheme;
		}
		else
		{
			//toggle panel to light mode
			panel.Theme = lightTheme;
		}
	}

}
