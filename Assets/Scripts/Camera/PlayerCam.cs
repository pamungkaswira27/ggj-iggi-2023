using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCam : MonoBehaviour
{

    Camera cam;

    [Header("Camera Border")]
    [SerializeField] float topBorder;
    [SerializeField] float leftBorder;
    [SerializeField] float rightBorder;
    [SerializeField] float botBorder;

    float topPos;
    float leftPos;
    float rightPos;
    float botPos;

    void Awake()
    {
        cam = Camera.main;
    }

    void Update()
    {
        CamBorder();
    }

    private void FixedUpdate()
    {
        CamFollow();
    }

    void CamBorder() {
        topPos = cam.transform.position.y + topBorder;
        leftPos = cam.transform.position.x - leftBorder;
        rightPos = cam.transform.position.x + rightBorder;
        botPos = cam.transform.position.y - botBorder;
    }

    void CamFollow() {
        Vector3 curPos = cam.transform.position;
        Vector3 playerPos = transform.position;
        float newX = curPos.x;
        float newY = curPos.y;

        if (transform.position.x <= leftPos)
        {
            newX = playerPos.x + leftBorder;
        }
        if (transform.position.x >= rightPos)
        {
            newX = playerPos.x - rightBorder;
        }
        if (transform.position.y <= botPos)
        {
            newY = playerPos.y + botBorder;
        }
        if (transform.position.y >= topPos)
        {
            newY = playerPos.y - topBorder;
        }

        Vector3 newPos = new(newX, newY, cam.transform.position.z);

        cam.transform.position = newPos;
    }
}
