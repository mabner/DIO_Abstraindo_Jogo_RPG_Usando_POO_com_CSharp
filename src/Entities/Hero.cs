namespace code.src.Entities
{
	public abstract class Hero
	{
		// Constructor
		public Hero(string Name, int Level, string HeroType)
		{
			this.Name = Name;
			this.Level = Level;
			this.HeroType = HeroType;
		}

		public string Name;

		public int Level;

		public string HeroType;

		public override string ToString()
		{
			return $"{this.HeroType} {this.Name}. Level {this.Level}.";
		}

		public virtual string Attack()
		{
			return $"{this.Name} attacks!.";
		}
	}
}