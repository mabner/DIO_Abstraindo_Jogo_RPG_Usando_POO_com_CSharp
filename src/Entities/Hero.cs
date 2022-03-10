namespace code.src.Entities
{
	public class Hero
	{
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
	}
}