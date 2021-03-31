namespace PacktLibrary9.Records
{
    public record ImmutableAnimal
    {
        string Name;
        string Species;
        public ImmutableAnimal(string name, string species)
        {
            Name = name;
            Species = species;
        }
        public void Deconstruct(out string name, out string species){
            name=Name;
            species=Species;
        }
    }
}