using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragandrop : MonoBehaviour
{
    Camera _cam;
    [SerializeField] LayerMask layermask;
    void Start()
    {
        _cam = Camera.main;
    }

    void Update()
    {
        MouseClick();
    }

    public void MouseClick()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f;
        mousePos = _cam.ScreenToWorldPoint(mousePos);
        Debug.DrawRay(transform.position, mousePos - transform.position, Color.blue);

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100, layermask))
            {




                if (hit.transform.gameObject.name == "Stul")
                {
                    UIManager.instance.CollectItem(hit.transform.gameObject.name);
                    Destroy(hit.transform.gameObject);
                }
                if (hit.transform.gameObject.name == "Eynek")
                {
                    UIManager.instance.CollectItem(hit.transform.gameObject.name);
                    Destroy(hit.transform.gameObject);
                }
                if (hit.transform.gameObject.name == "Daraq")
                {
                    UIManager.instance.CollectItem(hit.transform.gameObject.name);
                    Destroy(hit.transform.gameObject);
                }





                if (hit.transform.gameObject.name == "Use Stul")
                {
                    UIManager.instance.UseItem(hit.transform.gameObject.name);

                }
                if (hit.transform.gameObject.name == "Use Eynek")
                {
                    UIManager.instance.UseItem(hit.transform.gameObject.name);
                }
                if (hit.transform.gameObject.name == "Use Daraq")
                {
                    UIManager.instance.UseItem(hit.transform.gameObject.name);
                }

            }
        }
    }
}
