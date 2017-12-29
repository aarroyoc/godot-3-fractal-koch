using Godot;

public class Turtle {
    private float angle = 0;
    private Node2D canvas;
    private Vector2 origen;
    private Color color;
    public Turtle(Node2D canvas)
    {
        this.canvas = canvas;
        this.origen = new Vector2(0,0);
        this.color = new Color(1,0,0);
    }

    public void MoveForward(float length)
    {
        var to = new Vector2(origen.x+length*Mathf.Cos(angle),origen.y+length*Mathf.Sin(angle));
        canvas.DrawLine(origen,to,color);
        origen = to;
    }

    public void Rotate(float angle)
    {
        this.angle += Mathf.Deg2Rad(angle);
    }
}