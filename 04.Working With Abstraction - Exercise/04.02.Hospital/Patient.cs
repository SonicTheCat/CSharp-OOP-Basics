class Patient
{
    private string name; 

    public string Name
    {
        get => this.name;
        set => this.name = value; 
    }

    public Patient(string name)
    {
        Name = name;
    }
}