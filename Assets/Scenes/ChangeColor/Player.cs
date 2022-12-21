using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePos = Mouse.current.position.ReadValue();
            Ray rayOrigin = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                MeshRenderer hitObject = hitInfo.collider.GetComponent<MeshRenderer>();

                if (hitObject != null)
                {
                    hitObject.material.color = Random.ColorHSV();
                }
            }
        }
    }
}
