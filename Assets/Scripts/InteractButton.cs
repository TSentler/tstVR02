using UnityEngine;

public class InteractButton : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "RedButton")
        {
            print("есть контакт");
            FindAnyObjectByType<PotionSystem>().BrewPotion();
        }
    }
}
