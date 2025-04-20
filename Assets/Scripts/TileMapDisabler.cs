using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapDisabler : MonoBehaviour
{
    public void Awake()
    {
        GetComponent<TilemapRenderer>().enabled = false;
    }
}
