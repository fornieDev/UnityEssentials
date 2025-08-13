using UnityEngine;

public class Ballsound : MonoBehaviour
{
    private AudioSource audioSource;
    public float volumenImpacto;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!audioSource.isPlaying)
        {
            audioSource.volume = collision.relativeVelocity.magnitude * volumenImpacto;
            audioSource.Play();
        }
    }
}
