using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float runSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform playerTransform = GetComponent<Transform>();
        playerTransform.Translate(Vector3.forward * runSpeed * Time.deltaTime);
    }
}
