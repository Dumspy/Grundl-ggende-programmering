using Case1;

RecallVehicle[] recallVehicles = new[]
{
    new RecallVehicle("fiat", "punto", new DateTime(2010, 1, 1), "Udstødning"),
    new RecallVehicle("alfa romeo", "giulia", new DateTime(2019, 8, 1), "Styretøjet"),
};
    
while (true)
{
    Console.Clear();
    Console.Write("Mærke:");
    string? make = Console.ReadLine();

    Console.Write("Model:");
    string? model = Console.ReadLine();

    bool invalidDate = true;
    DateTime productionDate = DateTime.Now;
    while (invalidDate)
    {
        try
        {
            Console.Write("Produktionsdato:");
            productionDate = DateTime.Parse(Console.ReadLine());
            invalidDate = false;
        }
        catch
        {
            Console.WriteLine("Ugyldig dato");
        }
    }
    
    invalidDate = true;
    DateTime registrationDate = DateTime.Now;
    while (invalidDate)
    {
        try
        {
            Console.Write("Registreringsdato:");
            registrationDate = DateTime.Parse(Console.ReadLine());
            if(productionDate>registrationDate)
                throw new Exception("Ugyldig dato");
            invalidDate = false;
        }
        catch
        {
            Console.WriteLine("Ugyldig dato");
        }
    }
    
    invalidDate = true;
    string? latestInspectionDateInput = String.Empty;
    DateTime? latestInspectionDate = null;
    while (invalidDate)
    {
        try
        {
            Console.Write("Seneste syns dato:");
            latestInspectionDateInput = Console.ReadLine();
            latestInspectionDate = DateTime.Parse(latestInspectionDateInput);
            invalidDate = false;
        }
        catch
        {
            if (latestInspectionDateInput == string.Empty)
            {
                invalidDate = false;
                break;
            }
            Console.WriteLine("Ugyldig dato (efterlad tom hvis ingen syns dato))");
        }
    }

    if (make == null || model == null)
    {
        Console.WriteLine("Ugyldig input");
        Console.ReadLine();
        continue;
    }

    InspectionChecker inspectionChecker = latestInspectionDate.HasValue ? new InspectionChecker(registrationDate, latestInspectionDate.Value) : new InspectionChecker(registrationDate);
    
    Console.WriteLine(inspectionChecker.NeedInspection ? "Bilen skal til syn" : "Bilen skal ikke synes");
    var recallChecker = new RecallChecker(make,model, productionDate, recallVehicles);
    if (recallChecker.Recalled)
    {
        Console.WriteLine($"Bilen er tilbagekaldt grundet {recallChecker.Reason}");
    }

    Console.ReadLine();
}