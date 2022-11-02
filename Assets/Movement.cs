using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody2D body;
    public float speed;
    public float rotationSpeed;
    private float vertical;
    private float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();

    }


    // Update is called once per frame
    void Update()
    {
        Rigidbody2D body = GetComponent<Rigidbody2D>();

        float translation = Input.GetAxis("Vertical") * rotationSpeed;
        float rotation = Input.GetAxis("Horizontal") * speed;
        body.velocity = (transform.forward * vertical) * speed * Time.fixedDeltaTime;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
    }
    void onGUI()
    {
        if ((Input.GetKeyDown(KeyCode.D)))
            Debug.Log("Horizontal is Pressed");
        GUIUtility.ExitGUI();
    }
}