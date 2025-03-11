using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 0.5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += Vector3.left * speed * Time.deltaTime;
        //if (transform.position.x < -19.2f)
        //{ // Adjust based on width
        //    transform.position += Vector3.right * 19.2f * 2;

        //}
    }
}