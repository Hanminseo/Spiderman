using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15f;
    private Rigidbody rb;

    // Start is called before the first frame update
    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        var h = Input.GetAxisRaw("Horizontal");
        var v = Input.GetAxisRaw("Vertical");
        var direction = new Vector3(h, 0.0f, v);
        direction.Normalize();
        var deltaPos = direction * speed * Time.deltaTime;
        var nextPos = transform.position + deltaPos;
        rb.MovePosition(nextPos);
    }
}
