using UnityEngine;

public class InteractButton : MonoBehaviour
{
    public Transform o;


    private void OnTriggerEnter(Collider collision)
    {
        print(collision.gameObject.name);
        if (collision.gameObject.tag == "RedButton")
        {
            print("есть контакт");
            FindAnyObjectByType<PotionSystem>().BrewPotion();
        }
    }
}
