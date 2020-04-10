using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player;
    public Animator anim;
    public SpriteRenderer m_SpriteRenderer;
    public Transform m_Transform;
    [SerializeField]
    private float speed = 10f;

    /* private void Start()
     {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
     }*/

    private void FixedUpdate()
    {
        anim.SetBool("Speed", false);
    }

        void OnMouseDrag()
    {
        
        if (!Player.lose)
        {           
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         //  if(mousePos.x > (m_Transform.position.x + 0.0723f) || mousePos.x < (m_Transform.position.x - 0.0723f))
          //  {
                //anim.SetBool("Speed", true);
                if (mousePos.x > (m_Transform.position.x + 0.05f))
                {
                    m_SpriteRenderer.flipX = false;
                    if (mousePos.x > (m_Transform.position.x + 0.0723f))
                    {
                        mousePos.x = 2.5f;
                        anim.SetBool("Speed", true);
                    }
                    
                }
                if (mousePos.x < (m_Transform.position.x - 0.05f))
                {
                    m_SpriteRenderer.flipX = true;
                    if (mousePos.x > (m_Transform.position.x - 0.0723f))
                    {
                        mousePos.x = -2.5f;
                        anim.SetBool("Speed", true);
                    }

                }
            // }

            //mousePos.x = mousePos.x > 2.5f ? 2.5f : mousePos.x;
            //mousePos.x = mousePos.x < -2.5f ? -2.5f : mousePos.x;
            player.position = Vector2.MoveTowards(player.position,
                new Vector2(mousePos.x, player.position.y),
                speed * Time.deltaTime);
        }
        
    }
}
