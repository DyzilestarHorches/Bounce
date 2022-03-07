using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle
{ 
    public Vector2 midPoint, size;

    public Rectangle(Vector2 _midPoint, Vector2 _size)
    {
        midPoint = _midPoint;
        size = _size;
    }

    public bool insideCheck(Vector2 point)
    {
        if (point.x > midPoint.x + size.x || point.x < midPoint.x - size.x) return false;
        if (point.y > midPoint.y + size.y || point.y < midPoint.y - size.y) return false;
        return true;
    }
}
