using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] ParticleSystem destroyedShipVFX;

    GameSceneManager gameSceneManager;

    private void Start()
    {
        gameSceneManager = FindFirstObjectByType<GameSceneManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        Instantiate(destroyedShipVFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
        gameSceneManager.ReloadLevel();
    }
}
