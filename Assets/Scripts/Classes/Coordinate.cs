using UnityEngine;

//hichemRomdhane
public class Coordinate {
    public int x;
    public int y;
    public Vector3 pos; 

    public Coordinate(int x, int y) {
        this.x = x;
        this.y = y;
        pos = new Vector3(0, 0, 0);
    }
}