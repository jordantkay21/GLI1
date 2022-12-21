using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChangeCubeColor : MonoBehaviour
{
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePos = Mouse.current.position.ReadValue();
            Ray rayOrigin = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {

                {
                    MeshRenderer hitRenderer = hitInfo.collider.GetComponent<MeshRenderer>();

                    if (hitRenderer == null)
                    {
                        return;
                    }
                    switch (hitInfo.collider.tag)
                    {
                        case "Cube":
                            hitRenderer.material.color = Random.ColorHSV();
                            break;
                        case "Capsule":
                            hitRenderer.material.color = Color.black;
                            break;
                        case "Sphere":
                            break;
                    }

                }
            }
        }
    }
}
