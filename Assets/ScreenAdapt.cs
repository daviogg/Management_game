using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenAdapt : MonoBehaviour {

    public List<GameObject> MapBoard = new List<GameObject>();


    private void Awake()
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

        transform.localScale = new Vector2(transform.localScale.x, (float)worldScreenWidth / width);


    }

}
