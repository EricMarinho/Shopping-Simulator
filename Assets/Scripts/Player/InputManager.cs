using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    private PlayerController playerControllerInstance;

    private void Start()
    {
        playerControllerInstance = PlayerController.instance;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
        {
            if (!playerControllerInstance.isMovable) return;
            playerControllerInstance.moveCharacter();
        }
    }

}
