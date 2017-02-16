using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {
    private float rotation; 

    void Update() {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, rotation, 0), Time.deltaTime * 4f);
    }

    public void changeTeam(int team) {
        rotation = (team == -1) ? 0 : 180;
    }
}
