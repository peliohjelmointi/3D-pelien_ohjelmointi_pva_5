using UnityEngine;

namespace KS
{


    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] float moveSpeed;
        [SerializeField] float jumpPower;

        Rigidbody rb;
        CapsuleCollider capsuleCollider;


        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            capsuleCollider = GetComponent<CapsuleCollider>();
        }

        private void Start()
        {
            //Cursor.lockState = CursorLockMode.Locked;
        }

        private void Update()
        {
            MovePlayer();
        }

        private void FixedUpdate()
        {
            if (Utilities.isGrounded(transform, capsuleCollider) && Input.GetKeyDown(KeyCode.Space))
                rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }

        void MovePlayer()
        {
            float horizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
            float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
            transform.Translate(horizontal, 0, vertical);

            if (Input.GetKeyDown("escape"))
            {
                Cursor.lockState = CursorLockMode.None;
            }
        }


    }

}