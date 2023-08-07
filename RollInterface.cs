using Godot;
using Struct;
using System;

public class RollInterface : Button
{
	//store the node path of output label by exposing it in the inspector
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

		//get data from the attached node
		InterfaceData id = GetNode<InterfaceData>("Data");
		data = id.Data;
	}

	//randomly select from data string array and feed to output text
	private void Roll()
	{
		string outputText = data[rng.Randi() % data.Length];
		_output.Text = outputText;
	}
}
