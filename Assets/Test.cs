using System;
using UnityEngine;

public class Test : MonoBehaviour
{
    Action[] actions = new Action[10];
    void Start ()
    {
        
		for(int i=0;i<10;i++)
		{
		    int j = i;
		    actions[i] = () => Debug.Log(j);
		}
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            foreach (Action action in actions)
            {
                action.Invoke();
            }
        }
    }
}