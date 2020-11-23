namespace jsonserialization
{
    public class Author
    {
        public string Name { get; set; }
        public int YearOfBirth { get; set; }

        public override string ToString()
        {
            return Name + ", " + YearOfBirth;
        }
    }
}
