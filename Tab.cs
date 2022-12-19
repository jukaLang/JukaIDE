namespace JukaWebAssembly
{
    public class Tab
    {
        public string Name { get; set; }
        public int Status { get; set; } //0 = unedited, 1 = edited
        public string Code {get; set;}
        public EntryList Output{ get; set; }

        public Tab()
        {
            Name = "Untitled.juk";
            Status = 0;
            Code = "";
            Output = new();
        }

    }
}
