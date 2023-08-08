namespace Struct
{
	public class DataCombatDifficulty : InterfaceData
	{
		public override string[] Data { get; } =
		{
            "Very Easy: 1 Light Threat adversary per player or 1 Medium Threat adversary",
            "Very Easy: 1 Light Threat adversary per player or 1 Medium Threat adversary",
            "Easy: 2 Light Threat adversaries per player or 1 Medium Threat adversary per player",
            "Medium: 3 Light Threat adversaries per player or 2 Medium Threat adversaries per player or 1 High Threat adversary",
            "Hard: 3 Medium Threat adversaries per player or 1 High Threat adversary per 2 players or 1 Deadly Threat adversary",
            "Very Hard: (for 5+ Mission characters) 4 Medium Threat adversaries per player or 1 High Threat adversary per player or 2 Deadly Threat adversaries"
        };
	}
}
