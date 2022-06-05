using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkilLightning : ISkils
{
    public void skils(GameObject _mainPlayer)
    {
        _mainPlayer.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
}
