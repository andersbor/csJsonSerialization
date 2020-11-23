namespace jsonserialization
{
    class Book
    {
        public string Title { get; set; }
        public Author Auth { get; set; }

        public override string ToString()
        {
            return Title + ", by " + Auth;
        }
    }
}
