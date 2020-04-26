using System.IO;
using Full_GRASP_And_SOLID.Library;

// Aquí se hace una de las implementaciones del tipo IPrinter definido en la interfase.
// Se recibe una receta como parámetro y se implementa el método PrintRecipe para escribir
// un txt.

// Comentarios en IPrinter explican cómo se trabajó.

public class FilePrinter : IPrinter
{
    public void PrintRecipe(Recipe recipe)
    {
        File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
    }
}