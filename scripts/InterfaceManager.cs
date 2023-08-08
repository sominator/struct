using Godot;
using System;

public class InterfaceManager : Node2D
{
	//store scenes for loading upon option button selection
	public PackedScene GlobalObjective = GD.Load<PackedScene>("res://scenes/GlobalObjective.tscn");
	public PackedScene FactionObjective = GD.Load<PackedScene>("res://scenes/FactionObjective.tscn");
	public PackedScene FactionPoints = GD.Load<PackedScene>("res://scenes/FactionPoints.tscn");
	public PackedScene Locations = GD.Load<PackedScene>("res://scenes/Locations.tscn");
	public PackedScene Encounters = GD.Load<PackedScene>("res://scenes/Encounters.tscn");
	public PackedScene SkillDifficulty = GD.Load<PackedScene>("res://scenes/SkillDifficulty.tscn");
	public PackedScene Outcome = GD.Load<PackedScene>("res://scenes/Outcome.tscn");
	public PackedScene NPCs = GD.Load<PackedScene>("res://scenes/NPCs.tscn");
	public PackedScene NPCDisposition = GD.Load<PackedScene>("res://scenes/NPCDisposition.tscn");
	public PackedScene CombatDifficulty = GD.Load<PackedScene>("res://scenes/CombatDifficulty.tscn");
	public PackedScene Adversaries = GD.Load<PackedScene>("res://scenes/Adversaries.tscn");
	public PackedScene RedhatPatrols = GD.Load<PackedScene>("res://scenes/RedhatPatrols.tscn");
	public PackedScene TimeRifts = GD.Load<PackedScene>("res://scenes/TimeRifts.tscn");

	//store the selected scene
	private Node2D selectedInterface;

	public override void _Ready()
	{
		//instance the Global Objective scene at start and add it to the Main scene
		selectedInterface = (Node2D)GlobalObjective.Instance();
		AddChild(selectedInterface);
	}

	private void OnInterfaceChosen(string interfaceChoice)
	{
		//delete the current scene
		selectedInterface.QueueFree();

		//conditional logic to determine which scene to render based on option button selection
		switch (interfaceChoice)
		{
			case "GlobalObjective":
				selectedInterface = (Node2D)GlobalObjective.Instance();
				break;
			case "FactionObjective":
				selectedInterface = (Node2D)FactionObjective.Instance(); 
				break;
			case "FactionPoints":
				selectedInterface = (Node2D)FactionPoints.Instance();
				break;
			case "Locations":
				selectedInterface = (Node2D)Locations.Instance();
				break;
			case "Encounters":
				selectedInterface = (Node2D)Encounters.Instance();
				break;
			case "SkillDifficulty":
				selectedInterface = (Node2D)SkillDifficulty.Instance();
				break;
			case "Outcome":
				selectedInterface = (Node2D)Outcome.Instance();
				break;
			case "NPCs":
				selectedInterface = (Node2D)NPCs.Instance();
				break;
			case "NPCDisposition":
				selectedInterface = (Node2D)NPCDisposition.Instance();
				break;
			case "CombatDifficulty":
				selectedInterface =	(Node2D)CombatDifficulty.Instance();
				break;
			case "Adversaries":
				selectedInterface = (Node2D)Adversaries.Instance();
				break;
			case "RedhatPatrols":
				selectedInterface = (Node2D)RedhatPatrols.Instance();
				break;
			case "TimeRifts":
				selectedInterface = (Node2D)TimeRifts.Instance();
				break;
			default:
				selectedInterface = (Node2D)GlobalObjective.Instance();
				break;
		}

		//add selected scene to Main scene
		AddChild(selectedInterface);
	}
}
