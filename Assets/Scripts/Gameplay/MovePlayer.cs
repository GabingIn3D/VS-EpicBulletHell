using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public CharacterController characterController;
    public float speed = 6;
    public bool firstMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        Vector3 move = transform.right * horizontalMove;
        characterController.Move(speed * Time.deltaTime * move);
        if (!firstMove)
        {
            var variables = FindObjectOfType<CheckVariables>().GetComponent<CheckVariables>();
            variables.LeftTitleScreen();
            firstMove = true;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            var playerScript = GetComponent<HealthDisplay>();
            playerScript.Damage();
            print("Player has collided with enemy.");
            Destroy(other.gameObject);
        }
    }
}
