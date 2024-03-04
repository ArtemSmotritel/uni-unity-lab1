using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteExplosionCreator : MonoBehaviour
{
    private AudioSource explosionAudio;
    public GameObject explosionPrefab;
    private GameObject explosionGameObject; 
    // Start is called before the first frame update
    void Start()
    {
        LevelCompleteEventManager.AddEventListener(TriggerExplosion);
        explosionAudio = GetComponent<AudioSource>();
    }

    public void TriggerExplosion()
    {
        Invoke("Explode", 2);
    }

    private void Explode()
    {
        Vector3 position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);

        this.explosionGameObject = Instantiate(explosionPrefab, position, transform.rotation);
        explosionAudio.PlayOneShot(explosionAudio.clip);
        Invoke("CleanUp", 2);
    }

    private void CleanUp()
    {
        Destroy(this.explosionGameObject);
    }
}
