using System;
using System.Collections.Generic;
using System.Text;
public abstract class CookingProcess
{
    public void CookMeal()
    {
        PrepareIngredients();
        MainCookingStep();
        ServeDish();
    }
    private void PrepareIngredients()
    {
        Console.WriteLine("Подготовка: Ингредиенты вымыты, нарезаны и разложены по мискам.");
    }
    protected abstract void MainCookingStep();
    private void ServeDish()
    {
        Console.WriteLine("Подача: Блюдо красиво выложено на тарелку. Приятного аппетита!");
        Console.WriteLine(new string('-', 30));
    }
}
public class Soup : CookingProcess
{
    protected override void MainCookingStep()
    {
        Console.WriteLine("Основной процесс: Ингредиенты варятся в бульоне на медленном огне.");
    }
}
public class Steak : CookingProcess
{
    protected override void MainCookingStep()
    {
        Console.WriteLine("Основной процесс: Мясо жарится на сильно разогретой сковороде до состояния средней прожарки.");
    }
}