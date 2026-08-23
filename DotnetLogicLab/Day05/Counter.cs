namespace CSharpPractise.DotnetLogicLab.Day05;

public class Counter
{
    //Shared across all the instances
    private static int objectCount = 0;

    //Instance field 
    private int instanceId;

    public Counter()
    {
        objectCount++;
        instanceId = objectCount; // Assign unique ID to this instance
    }

    // Static method to get total object count
    public static int GetObjectCount()
    {
        return objectCount;
    }

// Static property (alternative to method)
    public static int ObjectCount
    {
        get { return objectCount; }
    }
    // Instance method to display this object's info
    public void DisplayInfo()
    {
        Console.WriteLine($"Object ID: {instanceId}, Total Objects Created: {objectCount}");
    }
}