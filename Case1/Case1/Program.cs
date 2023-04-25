using System.Globalization;
using Case1;


#region Array's

// String Array
string[] bilmærker = new string[] {"Fiat","Toyota","Kia"};
Console.WriteLine(bilmærker[2]);
foreach (var mærke in bilmærker)
{
    Console.WriteLine(mærke);
}


// Object Array
object[] objSamling = new object[] { "Hello!", 12, new DateTime(2020, 12, 31) };
var datetime = DateTime.Parse(objSamling[2].ToString());
Console.WriteLine($"{datetime.ToString("F", new CultureInfo("da-DK"))}");
foreach (var obj in objSamling)
{
    Console.WriteLine(obj);
}

// Class Array
modelClass[] models = new modelClass[] {new modelClass("Fiat"), new modelClass("Toyota"), new modelClass("Kia")};
Console.WriteLine(models[2].Name);
foreach (var model in models)
{
    Console.WriteLine(model.Name);
}

// 2D Array
string[][] bilMærker2D = new string[2][];
bilMærker2D[0] = new string[] { "Toyota", "Mazda", "Nissan", "Suzuki" };
bilMærker2D[1] = new string[] { "Audi", "BMV", "Mercedes" };

Console.WriteLine(bilMærker2D[0][3]);

foreach (var subArray in bilMærker2D)
{
    foreach (var mærke in subArray)
    {
        Console.WriteLine(mærke);
    }
}

// 3D Array
string[,,] bilMærker3D = new string[2, 2, 3]
{
    { // Japanske køretøjer
        {"Toyota", "Mazda", "Nissan"}, // Bil mærker
        {"Honda", "Suzuki", "Yamaha"} // Motorcykel mærker
    },
    { // Amerikanske køretøjer
        {"Ford", "Chevrolet", "Dodge"}, // Bil mærker
        {"Harley Davidson", "Buell", "Indian" } // Motorcykel mærker
    }
};

Console.WriteLine(bilMærker3D[0, 1, 2]);
foreach(string mærke in bilMærker3D)
{
    Console.WriteLine(mærke);
}

#endregion

#region List
// String list
List<string?> bilMærkerList = new() {"Fiat","Toyota","Kia"};
Console.WriteLine(bilMærkerList[2]);
foreach (var mærke in bilMærkerList)
{
    Console.WriteLine(mærke);
}

// Object list
List<object> objSamlingList = new() { "Hello!", 12, new DateTime(2020, 12, 31) };
Console.WriteLine($"{((DateTime)objSamlingList[2]).ToString("F", new CultureInfo("da-DK"))}");
foreach (var obj in objSamlingList)
{
    if(obj.GetType() == typeof(DateTime))
        Console.WriteLine($"{((DateTime)obj).ToString("F", new CultureInfo("da-DK"))}");
    else
        Console.WriteLine(obj);
}

// Class list
List<modelClass> modelsList = new() {new modelClass("Fiat"), new modelClass("Toyota"), new modelClass("Kia")};
Console.WriteLine(modelsList[2].Name);
foreach (var model in modelsList)
{
    Console.WriteLine(model.Name);
}

// 2D List
List<List<string>> bilMærker2DList = new()
{
    new List<string> { "Toyota", "Mazda", "Nissan", "Suzuki" },
    new List<string> { "Audi", "BMV", "Mercedes" }
};

Console.WriteLine(bilMærker2DList[0][3]);
foreach(var list in bilMærker2DList)
{
    foreach (var mærke in list)
    {
        Console.WriteLine(mærke);
    }
}

#endregion