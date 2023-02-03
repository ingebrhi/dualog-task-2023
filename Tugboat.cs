class Tugboat : Vessel{

    private double max_force { set; get; }

    public Tugboat (string Name, int Year, double Speed, double Force):base(Name, Year, Speed) {
        max_force = Force;
    }

    public override string ToString()
    {
        return $"Max force: {max_force}N";
    }
    
}