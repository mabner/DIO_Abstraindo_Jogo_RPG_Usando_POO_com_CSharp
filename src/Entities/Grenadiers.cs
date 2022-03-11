namespace code.src.Entities
{
	public class Grenadiers : Hero
	{
		public Grenadiers(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
		{
			this.Name = Name;
			this.Level = Level;
			this.HeroType = HeroType;
		}

		public override string Attack()
		{
			return $"{this.Name} attacks using.";
		}

		public string Attack(int Power)
		// encapsulating the power of the attack inside the method
		// outside code only needs to pass the attack number
		{
			if (Power < 6)
			{
				return $"{this.Name} attacks using shrapnel granade. Caused {Power} damage.";
			}
			else
			{
				return $"{this.Name} attacks using fire grenade. Caused {Power} damage.";
			}
		}
	}
}