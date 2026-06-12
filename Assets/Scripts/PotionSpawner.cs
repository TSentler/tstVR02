using UnityEngine;
public class PotionSpawner : MonoBehaviour
{
    public Transform SpawnPoint;

    public void Spawn(GameObject potion)
    {
        GameObject newPotion = Instantiate(potion, SpawnPoint.position,Quaternion.identity);
        newPotion.GetComponentInChildren<Rigidbody>().AddForce(new Vector3(0,1,1)*15f,ForceMode.Impulse);
    }
}
