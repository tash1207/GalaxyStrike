using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] ParticleSystem destroyedShipVFX;

    void OnParticleCollision(GameObject other)
    {
        Instantiate(destroyedShipVFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
