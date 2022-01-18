using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class MakeObjectLarge : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public float xSize;
    public float ySize;
    public float zSize;

    Vector3 cachedScale;

    // Start is called before the first frame update
    void Start()
    {
        cachedScale = transform.localScale;
    }

    //Detect if the Cursor starts to pass over the GameObject
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);

    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        transform.localScale = cachedScale;
    }
}
