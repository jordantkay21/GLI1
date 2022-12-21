using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Instantiatecube : MonoBehaviour
{
    [SerializeField]
    private GameObject _spherePrefab;

    // Update is called once per frame
    void Update()
    {

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePos = Mouse.current.position.ReadValue();
            Ray rayOrigin = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                if(hitInfo.transform.tag == "Floor")
                {
                    Instantiate(_spherePrefab, hitInfo.point, Quaternion.identity);
                }
            }
        }
    }
}
