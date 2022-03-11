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

		public string Attack(string weapon)
		{
			return $"{this.Name} attacks using {weapon} grenades.";
		}
	}
}