using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCursor : MonoBehaviour
{
    public Texture2D CursorTexture;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(CursorTexture, new Vector2(0, 0), CursorMode.Auto);
    }

}
