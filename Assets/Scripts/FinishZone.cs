using System.Collections;
using UnityEngine;

public class FinishZone : MonoBehaviour
{
    BallScript ballScript;
    public string GameSceneName;
    private bool canLoad;
    

    private void Start()
    {
        canLoad = false;
        ballScript = FindObjectOfType<BallScript>();
    }

    private void Update()
    {
        if (canLoad)
            StartCoroutine(ChangeScene());
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            ballScript.canMove = false;

            Vector3 vector = transform.position - collision.transform.position;
            vector = vector.normalized;
            collision.rigidbody.AddForce(vector * 300f);
            
            canLoad = true;
        }
    }


    IEnumerator ChangeScene()
    {
        float startTime = Time.time;
        float elapsedTime = 0f;
        float timerDuration = 1f;

        while (elapsedTime <= timerDuration)
        {
            elapsedTime = Time.time - startTime;
            yield return null;
        }
        SceneRoutingManager.ChangeScene();
    }

}
