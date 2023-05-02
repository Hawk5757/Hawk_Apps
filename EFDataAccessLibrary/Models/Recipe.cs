namespace EFDataAccessLibrary.Models;

public class Recipe
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Ingredient { get; set; }
    public string StepByStep { get; set; }
    public string Kind { get; set; }
    public string FoodClassification { get; set; }
}