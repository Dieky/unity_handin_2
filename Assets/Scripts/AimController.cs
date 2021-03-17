using UnityEngine;

public class AimController : MonoBehaviour
{

    public RectTransform myRectTransform;

    void Start()
    {
         Cursor.visible = false;
    }

    void Update()
    {
        var crosshairPos = Input.mousePosition;
        myRectTransform.position = crosshairPos;
    }

}
