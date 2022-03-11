namespace code.src.Entities
{
	public class Rifleman : Hero
	{
		public Rifleman(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
		{
			this.Name = Name;
			this.Level = Level;
			this.HeroType = HeroType;
		}
	}
}