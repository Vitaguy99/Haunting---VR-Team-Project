using Gvr.Internal;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public GameObject selectedObject;
    void Start()
    {
        
    }

    
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;

        if( Physics.Raycast( ray, out hitInfo ))
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
        //Works, color change is weird now that .gameObject.tag == "Item" has been added fix that!
        // still Doesent work when looking trigger is .setactive...
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

        selectedObject = null;
    }
}
