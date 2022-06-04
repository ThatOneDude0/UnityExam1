using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkilFire : ISkils
{
    public void skils(GameObject _mainPlayer)
    {
        _mainPlayer.transform.localScale = new Vector3(2, 2, 2);
    }
}
