using UnityEngine;


public class Square : MonoBehaviour {
    private Material cur_mat;

    public Coordinate coor; 
    public Piece holding_piece = null; 
    public Material start_mat;
    [SerializeField]
    public int team;

    [SerializeField]
    public Board board;

    void Start() {
        start_mat = GetComponent<Renderer>().material;
    }

    public void holdPiece(Piece piece) {
        holding_piece = piece;
    }

    public void hoverSquare(Material mat) {
        cur_mat = GetComponent<Renderer>().material;
        GetComponent<Renderer>().material = mat;
    }

    public void unHoverSquare() {
        GetComponent<Renderer>().material = cur_mat;
    }

    public void resetMaterial() {
        cur_mat = start_mat;
        GetComponent<Renderer>().material = start_mat;
    }
}
