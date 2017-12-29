using Godot;
using System;
using LiteDB;

/**
How to build:
nuget restore
msbuild /p:Configuration=Tools
godot
 */
public class Canvas : Node2D
{

    public override void _Ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
        
    }

    private void Koch(Turtle turtle,float length,int level)
    {
        if(level > 1){
            Koch(turtle,length/3,level -1);
        }else{
            turtle.MoveForward(length);
        }
        turtle.Rotate(-60);
        if(level > 1){
            Koch(turtle,length/3,level -1);
        }else{
            turtle.MoveForward(length);
        }
        turtle.Rotate(120);
        if(level > 1){
            Koch(turtle,length/3,level -1);
        }else{
            turtle.MoveForward(length);
        }
        turtle.Rotate(-60);
        if(level > 1){
            Koch(turtle,length/3,level -1);
        }else{
            turtle.MoveForward(length);
        }
    }


    private Vector2 KochEnd(Vector2 origin,float length)
    {
        var color = new Color(1,0,0,1);
        var to = new Vector2(origin.x+length,origin.y);
        DrawLine(origin,to,color);
        origin = to;
        to = new Vector2(origin.x+length*(float)Math.Cos(Math.PI/3),origin.y-length*(float)Math.Cos(Math.PI/6));
        DrawLine(origin,to,color);
        origin = to;
        to = new Vector2(origin.x+length*(float)Math.Cos(Math.PI/3),origin.y+length*(float)Math.Cos(Math.PI/6));
        DrawLine(origin,to,color);
        origin = to;
        to = new Vector2(origin.x+length,origin.y);
        DrawLine(origin,to,color);
        return to;
    }

    public override void _Draw()
    {
        /*var color = new Color(1,0,0,1);
        var rect = new Rect2(0,0,20,10);
        DrawRect(rect,color,true);*/

        //KochEnd(new Vector2(0,0),10);
        var turtle = new Turtle(this);
        Koch(turtle,10,5);
        turtle.Rotate(120);
        Koch(turtle,10,5);
        turtle.Rotate(120);
        Koch(turtle,10,5);

    }

//    public override void _Process(float delta)
//    {
//        // Called every frame. Delta is time since last frame.
//        // Update game logic here.
//        
//    }
}
