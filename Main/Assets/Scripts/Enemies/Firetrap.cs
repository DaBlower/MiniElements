using UnityEngine;

public class Firetrap : MonoBehaviour
{
    [Header("Firetrap Timers")]
    [SerializeField] private float activationDelay;
    [SerializeField] private float activeTime;
    private Animator anim;
    private SpriteRenderer spriteRend;
    [SerializeField] private float damage;

    private bool triggered; //if the trap is triggered
    private bool active; //if the trap is active

    private void Awake()
    {
        anim = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(!triggered)
            {
                //triggered the firetrap

            }
            if (active)
                collision.GetComponent<Health>().TakeDamage(damage);
        }
    }

}

//6:40