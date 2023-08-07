using Godot;
using System;

public class OptionInterfaces : OptionButton
{
	//simple enum to track interface option button values rather than passing them as indices
	enum Interfaces
	{
		GlobalObjective,
		FactionObjective,
		FactionPoints,
		Locations,
		Encounters,
		SkillDifficulty,
		Outcome,
		NPCs,
		NPCDisposition,
		CombatDifficulty,
		Adversaries,
		RedhatPatrols,
		TimeRifts
	}
	public override void _Ready()
	{
		
	}

	//receive signal that Class option button selection has changed
	private void OptionInterfacesitemSelected(int index)
	{
		//emit signal of the chosen class as a string
		string interfaceChoice = ((Interfaces)index).ToString();
		EmitSignal(nameof(InterfaceChosen), interfaceChoice);
	}

	[Signal]
	private delegate void InterfaceChosen(string interfaceChoice);

}
