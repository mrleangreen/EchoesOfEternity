using Godot;
using System;

public partial class main_menu : Control
{
	[Export]
	string levelScene = "";
	BoxContainer mainButtons;
	BoxContainer settingsButtons;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("Main Menu Loaded");
		mainButtons = GetNode<BoxContainer>("CanvasLayer/MainButtons");
		settingsButtons = GetNode<BoxContainer>("CanvasLayer/SettingsButtons");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	//Main Menu Main Buttons
	//Starts the game by loading the player into the Farm
	private void _on_start_button_pressed()
	{
		GD.Print("Start Button has been pressed");
		GetTree().ChangeSceneToFile(levelScene);
	}
	//Changes visibility of Main Buttons off, and shows the settings menu
	private void _on_settings_button_pressed()
	{
		GD.Print("Settings button has been pressed");
		mainButtons.Visible = false;
		settingsButtons.Visible = true;
	}
	//Closes the game
	private void _on_exit_button_pressed()
	{
		GetTree().Quit();
	}
	private void _on_return_button_pressed()
	{
		mainButtons.Visible = true;
		settingsButtons.Visible = false;
	}
}
