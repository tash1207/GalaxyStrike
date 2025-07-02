using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] ParticleSystem destroyedShipVFX;
    [SerializeField] int hitPoints = 4;
    [SerializeField] int scoreValue = 10;

    Scoreboard scoreboard;

    void Start()
    {
        scoreboard = FindFirstObjectByType<Scoreboard>();
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        hitPoints--;

        if (hitPoints <= 0)
        {
            scoreboard.IncreaseScore(scoreValue);
            Instantiate(destroyedShipVFX, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
