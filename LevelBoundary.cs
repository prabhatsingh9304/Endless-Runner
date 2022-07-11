
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    // Start is called before the first frame update
    public static float leftSide = -1f;
    public static float rightSide = 1f;
    public Transform B_Right;
    public Transform B_Left;

    // Update is called once per frame
    void Update()
    {
        leftSide = B_Right.transform.position.x;
        rightSide = B_Left.transform.position.x;
    }
}
