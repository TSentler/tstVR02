using System.Collections.Generic;
using UnityEngine;

public class PotionSystem : MonoBehaviour
{
    public PotionSpawner spawner;

    public Cauldron cauldron;
    public GameObject Carrot;
    public GameObject Cat;

    public void BrewPotion()
    {
        List<IngredientType> ingredients = cauldron.currentIngredients;
        // vision potion
        if (ingredients.Contains(IngredientType.Mushroom) &&
            ingredients.Contains(IngredientType.Water) &&
            ingredients.Count == 2)
        {
            Debug.Log(" Зелье помутнения разума готово !");
            spawner.Spawn(Carrot);
        }
        else if (ingredients.Contains(IngredientType.Carrot) &&
            ingredients.Contains(IngredientType.Cloud) &&
            ingredients.Count == 2)
        {
            Debug.Log("Обьект  прыгающий кот готов !");
            spawner.Spawn(Cat);
        }
        else if (ingredients.Contains(IngredientType.Mushroom) &&
           ingredients.Contains(IngredientType.Bone) &&
           ingredients.Count == 2)
        {
            Debug.Log("Обьект паук!");
            spawner.Spawn(Spider);
            cauldron.ClearCauldron();
    }
}