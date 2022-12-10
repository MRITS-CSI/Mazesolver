using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum NodeState
{
    Possible,
    Current,
    Passed
}

public class MazeNode : MonoBehaviour
{
    [SerializeField] GameObject[] walls;
    [SerializeField] MeshRenderer floor;

    public void RemoveWall(int windex)
    {
        walls[windex].SetActive(false);
    }

    public void SetState(NodeState state)
    {
        switch(state)
        {
            case NodeState.Possible:
                floor.sharedMaterial.color = Color.green;
                break;
            case NodeState.Current:
                floor.sharedMaterial.color = Color.red;
                break;
            case NodeState.Passed:
                floor.sharedMaterial.color = Color.blue;
                break;
            default:
                break;
        }
    }
    
}
