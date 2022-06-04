using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChangeTwo : MonoBehaviour
{
    //private PlayerSkils _playerSkils;
    [SerializeField] private GameObject GameObject;
    private ISkils skils;

    private void Start()
    {
        skils = new SkilIce();
    }

    private void OnTriggerEnter(Collider other)
    {
        skils.skils(GameObject);
        ChangeSkils(new SkilFire());
    }

    public void ChangeSkils(ISkils skils)
    {
        this.skils = skils;
    }
}
