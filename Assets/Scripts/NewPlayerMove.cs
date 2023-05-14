using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewPlayerMove : MonoBehaviour
{
    
    public Transform Player;
    public float Speed;

    private void OnMouseDrag()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
        Player.position = new Vector3 (mousePos.x, Player.position.y);

        mousePos.x = mousePos.x > 11f ? 11f : mousePos.x;
        mousePos.x = mousePos.x < -9f ? -9f : mousePos.x;
        Player.position = Vector3.MoveTowards(mousePos, Player.position, Speed * Time.deltaTime);
    }
}
