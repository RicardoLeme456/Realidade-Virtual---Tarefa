using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnumAxis
{
    x,
    y,
    z,
}

public class Rotate : MonoBehaviour
{
    public EnumAxis axis;
    public float speed;

    private void Update()
    {
        switch (axis)
        {
            case EnumAxis.x:
                transform.Rotate(speed, 0, 0);
                break;
            case EnumAxis.y:
                transform.Rotate(0, speed, 0);
                break;
            case EnumAxis.z:
                transform.Rotate(0, 0, speed);
                break;
        }
    }

}
