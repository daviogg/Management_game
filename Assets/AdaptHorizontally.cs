using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdaptHorizontally : MonoBehaviour {

    void Awake()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if (sr == null) return;

        //transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
        //transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, 1);

        var width = sr.sprite.bounds.size.x;
        var height = sr.sprite.bounds.size.y;

        Debug.Log(height);

        var worldScreenHeight = Camera.main.orthographicSize * 2.0;
        var worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

        transform.localScale = new Vector2(transform.localScale.x, (float)worldScreenHeight / height);

        if (transform.localPosition.x < 0)
        {
            transform.position = new Vector3((float)((worldScreenWidth / (width)) / 4), transform.position.y, 1);
        }
        else
        {
            transform.position = new Vector3(-(float)((worldScreenWidth / (width)) / 4), transform.position.y, 1);

        }

    }
}
