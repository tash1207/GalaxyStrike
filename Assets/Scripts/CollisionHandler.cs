using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] ParticleSystem destroyedShipVFX;

    void OnTriggerEnter(Collider other)
    {
        Instantiate(destroyedShipVFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
