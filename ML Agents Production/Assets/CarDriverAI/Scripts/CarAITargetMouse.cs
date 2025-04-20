using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAITargetMouse : MonoBehaviour {

    [SerializeField] private Transform targetTransform;
    [SerializeField] private Vector2 mapMinBounds = new Vector2(-50f, -50f);
    [SerializeField] private Vector2 mapMaxBounds = new Vector2(50f, 50f);

    private void Start()
    {
        StartCoroutine(MoveTargetRoutine());
    }

    private IEnumerator MoveTargetRoutine()
    {
        while (true)
        {
            MoveTargetToRandomPosition();
            yield return new WaitForSeconds(5f);
        }
    }

    private void MoveTargetToRandomPosition()
    {
        float randomX = Random.Range(mapMinBounds.x, mapMaxBounds.x);
        float randomZ = Random.Range(mapMinBounds.y, mapMaxBounds.y);
        targetTransform.position = new Vector3(randomX, targetTransform.position.y, randomZ);
    }
}
