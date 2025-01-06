using UnityEngine;

public class FylingCubeScript : MonoBehaviour
{
    [SerializeField] float timetoWait =3f;
    [SerializeField] Rigidbody myRb;
    [SerializeField] MeshRenderer playerMeshRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
        playerMeshRenderer = GetComponent<MeshRenderer>();
        playerMeshRenderer.enabled =false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>=timetoWait)
        {
            myRb.useGravity =true;
            playerMeshRenderer.enabled =true;
        }
    }
}
