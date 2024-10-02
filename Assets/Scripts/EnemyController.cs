using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;
    private ParticleSystem hitParticles;
    private AudioSource audioSource;

    private EnemyHealth enemyHealth;
    private float health = 0;

    void Start()
    {
        animator = GetComponent<Animator>();
        hitParticles = GetComponent<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();
        enemyHealth = GetComponent<EnemyHealth>();
    }

    public void GotHit()
    {

        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(10);
            animator.SetTrigger("GotHit");
            hitParticles.Play();
            audioSource.Play();
        }
    }
}
