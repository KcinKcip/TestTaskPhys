using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed;
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EndLevel"))
        {
            Invoke("Restart", 2f);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Main");
    }

    private void Update()
    {
        rb.AddForce(new Vector3(0, -speed, 0));
    }
}
  