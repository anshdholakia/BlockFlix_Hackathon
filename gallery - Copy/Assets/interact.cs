using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{

    object OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name.StartsWith("Cube"));
        if (col.gameObject.name.StartsWith("Cube"))
        {
            Debug.Log(col.gameObject.name);
            Vector3 newPos = new Vector3(col.gameObject.transform.position.x, col.gameObject.transform.position.y + 0.1f, col.gameObject.transform.position.z);
            col.gameObject.transform.position = newPos;
            return col.gameObject;

        }
        return this;


    }

    object OnCollisionExit(Collision col)
    {
        Debug.Log(col.gameObject.name.StartsWith("Cube"));
        if (col.gameObject.name.StartsWith("Cube"))
        {
            Debug.Log(col.gameObject.name);
            Vector3 newPos = new Vector3(col.gameObject.transform.position.x, col.gameObject.transform.position.y - 0.1f, col.gameObject.transform.position.z);
            col.gameObject.transform.position = newPos;
            return col.gameObject;

        }
        return this;

    }



}
