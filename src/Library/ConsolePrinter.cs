using System;
using Full_GRASP_And_SOLID.Library;

// Aquí se hace una de las implementaciones del tipo IPrinter definido en la interfase.
// Se recibe una receta como parámetro y se implementa el método PrintRecipe para 
// escribir en pantalla.

// Comentarios en IPrinter explican cómo se trabajó.

public class ConsolePrinter : IPrinter
{
    public void PrintRecipe(Recipe recipe)
    {
        Console.WriteLine(recipe.GetTextToPrint());
    }
}