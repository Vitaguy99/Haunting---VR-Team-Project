using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerV2 : MonoBehaviour
{
    public GameObject selectedObject;

    public GameObject ghost;
    public GameObject Player;
    public float Speed;

    void Start()
    {

    }


    void Update()
    {
        ghost.transform.position = Vector3.MoveTowards(ghost.transform.position, Player.transform.position, Speed * Time.deltaTime);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo))
        {
            GameObject hitObject = hitInfo.transform.root.gameObject;

            SelectObject(hitObject);
        }
        else
        {
            ClearSelection();
        }
    }

    void SelectObject(GameObject obj)
    {
        if (obj.gameObject.tag == "Looking")
        {
            if (selectedObject != null)
            {
                if (obj == selectedObject)
                    return;

                ClearSelection();
            }

            selectedObject = obj;

            Speed = 0f;

            Renderer[] rs = selectedObject.GetComponentsInChildren<Renderer>();
            foreach (Renderer r in rs)
            {
                Material m = r.material;
                m.color = Color.red;
                r.material = m;
            }
        }

        if (obj.gameObject.tag == "Item")
        {
            if (selectedObject != null)
            {
                if (obj == selectedObject)
                    return;

                ClearSelection();
            }

            selectedObject = obj;

            Renderer[] rs = selectedObject.GetComponentsInChildren<Renderer>();
            foreach (Renderer r in rs)
            {
                Material m = r.material;
                m.color = Color.green;
                r.material = m;
            }
        }
    }

    void ClearSelection()
    {
        if (selectedObject == null)
            return;

        Renderer[] rs = selectedObject.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in rs)
        {
            Material m = r.material;
            m.color = Color.white;
            r.material = m;
        }  
        
        Speed = 2f;
        selectedObject = null;
    }
}
