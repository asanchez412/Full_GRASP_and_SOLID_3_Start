using System.IO;
using Full_GRASP_And_SOLID.Library;

public class FilePrinter : IPrinter
{
    public void PrintRecipe(Recipe recipe)
    {
        File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
    }
}