using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float forceValue;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector3(0, forceValue, 0));

    }
}
