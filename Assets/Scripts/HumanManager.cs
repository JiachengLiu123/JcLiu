using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
    public GameObject human;
    public float value;
    public Vector3 sizeChange;

    public void Move()
    {
        value = value - 0.1f;
        human.transform.position = new Vector3(value, 0, 0);
    }

    public void Rotate()
    {
        human.transform.Rotate(0f, 0f, 20f);
    }

    public void Grow()
    {
        human.transform.localScale = human.transform.localScale + sizeChange;
    }

    public void ResetPlayer()
    {
        human.transform.position = new Vector3(value, 0, 0);
        human.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        human.transform.localScale = new Vector3(1, 1, 1);
    }
}
