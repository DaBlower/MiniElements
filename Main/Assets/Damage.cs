using UnityEngine;

public class Damage : MonoBehaviour
{
    private Health player;
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            player = collision.GetComponent<Health>();
            player.TakeDamage(3);
            anim.SetTrigger("kill");
            
        }
    }
}
