class Submarine : Vessel {

    private double max_depth { set; get; }

    public Submarine (string Name, int Year, double Speed, double Depth):base(Name, Year, Speed) {
        max_depth = Depth;
    }
    
    public override string ToString()
    {
        return $"Max depth: {max_depth}km";
    }
}