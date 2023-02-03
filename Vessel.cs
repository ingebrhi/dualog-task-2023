class Vessel {
    private string name { get; set; }
    private int yearBuilt { get; set; }
    Speed max_speed { get; set; }

    public Vessel(string Name, int Year, double Speed) {
        name = SetName(Name);
        yearBuilt = SetYearBuilt(Year);
        max_speed = SetMaxSpeed(Speed);
    }

    public string SetName(string Name) {
        if (Name == null || Name.ToLower() == "null") {
            throw new ArgumentNullException("Name cannot be 'null'");
        } else {
            return name = Name;
        }
    }

    public int SetYearBuilt(int Year) {
        if (Year < (2023-20)) {
            throw new OldShipException("Ship cannot be more than 20 years old");
        } else if (Year > 2023) {
            throw new ArgumentOutOfRangeException("Year cannot be in the future");
        }
        else {
            return yearBuilt = Year;
        }
    }

    public Speed SetMaxSpeed(double Speed) {
        return max_speed = new Speed(Speed);
    }

    public string GetVesselType() {
        return this.GetType().Name;
    }

    public void GetVesselInfo(string type) {
        Console.WriteLine($"Type of vessel: {GetVesselType()}\nName: {name} \nYear built: {yearBuilt} \nMax speed: {max_speed.ToString(type)} \n{this.ToString()}\n");
    }

    public static void ShowVessels(List<Vessel> Vessels) {
        Console.WriteLine("Enter how you would like to view speed (knots (KN) or meters per second (MS)):");
        string? view = Console.ReadLine();

        if (view == "KN") {
            foreach (Vessel v in Vessels){
                v.GetVesselInfo(view);
            }
        } else if (view == "MS") {
            foreach (Vessel v in Vessels){
                v.GetVesselInfo(view);
            }
        } else {
            throw new IllegalSpeedTypeException("Invalid speed type.");
        }
    }

    public override string ToString() {
        return $"Name: {name} \nYear built: {yearBuilt}";
    }

    static void Main(string[] args) {

        Tugboat anne = new Tugboat("Anne", 2010, 15, 5.5);
        Ferry beate = new Ferry("Beate", 2006, 4.2, 200);
        Submarine cindy = new Submarine("Cindy", 2017, 8, 70);
        Ferry dina = new Ferry("Dina", 2020, 3.2, 40);
        Ferry ella = new Ferry("Ella", 2018, 2, 60);
        Tugboat frida = new Tugboat("Frida", 2010, 4.3, 3);

        List<Vessel> vessels = new List<Vessel>();
        vessels.Add(anne);
        vessels.Add(beate);
        vessels.Add(cindy);
        vessels.Add(dina);
        vessels.Add(ella);
        vessels.Add(frida);

        ShowVessels(vessels);

    }
}