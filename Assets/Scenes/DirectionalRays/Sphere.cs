using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        RaycastHit hitInfo;

      if (Physics.Raycast(transform.position, Vector3.down, out hitInfo, 2f))
        {
            if (hitInfo.transform.tag == "Floor")
            {
                this.gameObject.GetComponent<Rigidbody>().useGravity = false;
                this.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            }

        }  
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, Vector3.down * 2f);
    }
}
