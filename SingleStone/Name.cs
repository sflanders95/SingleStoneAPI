namespace SingleStone
{
    public class Name
    {
        public Name(string? First, string? Middle, string? Last)
        {
            this.First = First; this.Middle = Middle; this.Last = Last; 
        }
        public string? First { get; set; }
        public string? Middle { get; set; }
        public string? Last { get; set; }

    }
}
