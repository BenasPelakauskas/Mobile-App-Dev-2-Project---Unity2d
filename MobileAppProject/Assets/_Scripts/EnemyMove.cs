using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour
{

    private bool dirRight = true;
    public float speed = 2.0f;

    void Update()
    {
        Vector2 characterScale = transform.localScale;
        if (dirRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
        }

        if (transform.position.x >= 3.0f)
        {
            dirRight = false;
            transform.localScale = new Vector2(0.499f,0.457f);
        }

        if (transform.position.x <= -5)
        {
            dirRight = true;
            transform.localScale = new Vector2(-0.499f, 0.457f);
        }
    }
}
