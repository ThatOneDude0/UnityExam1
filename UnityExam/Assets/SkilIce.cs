using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkilIce : ISkils
{
    public void skils(GameObject _mainPlayer)
    {
        _mainPlayer.transform.localScale = new Vector3(1, 1, 1);
    }
}
