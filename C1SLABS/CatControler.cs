using UnityEngine;

/* public class CatControler : MonoBehaviour
{

    public Animator animator;
    public Transform AxeTransform;
    void Start()
    { }

        //triggers are for actions 1 per time
        //switches are bools
        animator.SetFloat("X", 0);
        animator.SetFloat("Y", 0);


        // Update is called once per frame
        void Update()
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");

            if (MoveDir)
            {
                animator.SetTrigger("OnMov");
            }

            Vector2 MoveDir = new Vector2(horizontal, vertical).normalized;

            animator.SetFloat("X", MoveDir.x);
            animator.SetFloat("Y", MoveDir.y);

            
            if (Input.GetKeyDown(KeyCode.F))
            {
                animator.SetTrigger("OnAttack"); // Parameter set on Animator Screen
                Collider2D[] Colisiones = Physics2D.OverlapCircleAll(AxeTransform.position, 2f);

                foreach (Collider2D col in Colisiones)
                {
                    if (col.CompareTag("Enemy"))
                    {
                        col.GetComponent<Enemy>().TakeDamage(1); //calling the script Enemy and the method TakeDamage with the damage value
                    }
                }
            }
        }
    }


*/