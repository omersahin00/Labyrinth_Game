using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    Transform ballTransform;
    BallScript ballScript;
    private bool upMove = false, downMove = false, rightMove = false, leftMove = false;


    private void Start()
    {
        ballTransform = GameObject.FindGameObjectWithTag("Ball").transform;
        ballScript = FindAnyObjectByType<BallScript>();
    }

    private void Update()
    {
        if (upMove) ballTransform.Translate(new Vector3(0f, 0f, 1f) * ballScript.speed * Time.deltaTime);
        if (downMove) ballTransform.Translate(new Vector3(0f, 0f, -1f) * ballScript.speed * Time.deltaTime);
        if (rightMove) ballTransform.Translate(new Vector3(1f, 0f, 0f) * ballScript.speed * Time.deltaTime);
        if (leftMove) ballTransform.Translate(new Vector3(-1f, 0f, 0f) * ballScript.speed * Time.deltaTime);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (ballScript.canMove && gameObject.name.Equals("ButtonUp")) upMove = true;
        if (ballScript.canMove && gameObject.name.Equals("ButtonDown")) downMove = true;
        if (ballScript.canMove && gameObject.name.Equals("ButtonRight")) rightMove = true;
        if (ballScript.canMove && gameObject.name.Equals("ButtonLeft")) leftMove = true;
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        if (ballScript.canMove && gameObject.name.Equals("ButtonUp")) upMove = false;
        if (ballScript.canMove && gameObject.name.Equals("ButtonDown")) downMove = false;
        if (ballScript.canMove && gameObject.name.Equals("ButtonRight")) rightMove = false;
        if (ballScript.canMove && gameObject.name.Equals("ButtonLeft")) leftMove = false;
    }
}
