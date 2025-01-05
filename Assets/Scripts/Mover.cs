using UnityEngine;

public class Mover : MonoBehaviour
{

    float moveSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
