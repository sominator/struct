using Godot;
using Struct;
using System;

public class RollInterface : Button
{
	//store the node paths of output label by exposing them in the inspector
	[Export]
	private NodePath _outputPath;
	
	private Label _output;

	//store string array
	private string[] data;

	//store new RNG
	private RandomNumberGenerator rng = new RandomNumberGenerator();

	public override void _Ready()
	{
		//seed RNG
		rng.Randomize();
		_output = GetNode<Godot.Label>(_outputPath);
		data = InterfaceData.GlobalObjectiveData;
	}

	private void Roll()
	{
		string outputText = data[rng.Randi() % data.Length];
		_output.Text = outputText;
	}
}
