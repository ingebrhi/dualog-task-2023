class Ferry : Vessel{

    public int passengers { get; set; }

    public Ferry(string Name, int Year, double Speed, int Passengers):base(Name, Year, Speed) {
        passengers = Passengers;
    }

    public override string ToString() {
        return $"Max passengers: {passengers}";
    }
}