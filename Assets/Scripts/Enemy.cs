using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] ParticleSystem destroyedShipVFX;
    [SerializeField] int hitPoints = 4;

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        hitPoints--;

        if (hitPoints <= 0)
        {
            Instantiate(destroyedShipVFX, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
