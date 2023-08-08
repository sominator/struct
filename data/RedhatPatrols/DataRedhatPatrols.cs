namespace Struct
{
	public class DataRedhatPatrols : InterfaceData
	{
		public override string[] Data { get; } =
		{
			"The redhat patrol takes you and your party in for questioning, immediately ending your current encounter and requiring you to complete one additional encounter to complete your global objective.",
			"A high speed chase occurs, complicating your objective but not beyond repair.  Implement the Skill Difficulty interface (Table 6 in Module 2: Struct) and make a Vehicles check. On a success, you proceed with your current encounter; on a failure, your encounter ends and you must choose a new one.",
			"An opportunity for reconciliation appears, providing a brief window for exchange. Implement the Skill Difficulty interface (Table 6 in Module 2: Struct) and make a Negotiation check. On a success, you proceed with your current encounter; on a failure, your encounter ends and you must choose a new one.",
			"Your encounter with the redhat patrol is uniquely situated to allow for dialogue across party lines. You can spend one faction point from the faction for which you have the highest faction point total to reconcile with the redhat patrol, bypassing any further redhat encounters for the remainder of the current mission. If you do not choose to resolve the encounter in this manner, implement the Redhat Patrols interface again."

		};
	}
}
