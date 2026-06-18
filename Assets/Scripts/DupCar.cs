using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class DupCar : MonoBehaviour
{
    public PotionSpawner spawner;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Rigidbody>())
        {
            spawner.Spawn(other.gameObject);
        }
            
    }

}
