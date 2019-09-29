using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Snake : MonoBehaviour
{
    Vector2 direction = Vector2.right;

    LinkedList<Transform> tail = new LinkedList<Transform>();
    bool eaten = false;
    public GameObject tailPrefab;
    public int loseSceneIndex;

    void Start()
    {
        InvokeRepeating("Move", 0.5f, 0.5f);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            direction = Vector2.right;
        else if (Input.GetKey(KeyCode.DownArrow))
            direction = Vector2.down;
        else if (Input.GetKey(KeyCode.LeftArrow))
            direction = Vector2.left;
        else if (Input.GetKey(KeyCode.UpArrow))
            direction = Vector2.up;
    }

    void Move()
    {
        Vector2 pos = transform.position;

        transform.Translate(direction);

        if (eaten)
        {
            GameObject tailPiece = (GameObject)Instantiate(tailPrefab, pos, Quaternion.identity);
            tail.AddFirst(tailPiece.transform);
            eaten = false;
        }

        else if (tail.Count>0)
        {

            tail.Last().position = pos;

            tail.AddFirst(tail.Last());

            tail.RemoveLast();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.StartsWith("Food")) //todo: convert to Tag
        {
            //Debug.Log("I have eaten an apple!");
            Destroy(collision.gameObject);
            eaten = true;
        }
        else
        {
            //Debug.Log("I crashed into my tail or the wall!");
            SceneManager.LoadScene(loseSceneIndex);
        }
    }
}
